namespace VehicleAvlTrackingConsumer.Service.Processor;

using System.Diagnostics;
using System.Text.Json;
using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VehicleAvlTrackingConsumer.Cache;
using VehicleAvlTrackingConsumer.Exceptions;
using VehicleAvlTrackingConsumer.Interface;
using VehicleAvlTrackingConsumer.Models.Jadeh;
using VehicleAvlTrackingConsumer.Models.VehicleAvl;
using VehicleAvlTrackingConsumer.Models.VehicleAvl.Dto;


public class VehicleAvlProcessor : IVehicleAvlProcessor
{
    private readonly VehicleCache _vehicleCache;
    private readonly DeviceCache _deviceCache;
    private readonly IServiceScopeFactory _scopeFactory;
    private readonly VehicleAvlTrackingDbContext _mysqlDb;
    private readonly ILogger<VehicleAvlProcessor> _logger;
    public VehicleAvlProcessor(
        VehicleCache vehicleCache,
        DeviceCache deviceCache,
        VehicleAvlTrackingDbContext mysqlDb,
        IServiceScopeFactory scopeFactory,
        ILogger<VehicleAvlProcessor> logger
        )
    {
        _vehicleCache = vehicleCache;
        _deviceCache = deviceCache;
        _mysqlDb = mysqlDb;
        _scopeFactory = scopeFactory;
        _logger = logger;
    }

    public async Task ProcessAsync(DateTime start, DateTime end, CancellationToken ct)
    {

        DateTime? lastDeviceTime = null; // Keep track
        var mainStopwatch = Stopwatch.StartNew();

        try
        {

            _logger.LogInformation("Vehicle AVL processing started from {Start} to {End}", start, end);

            var cachedVehicles = _vehicleCache.GetVehicles();
            var cachedDevices = _deviceCache.GetDevices();

            int mySqlQueryBatchSize =300_000;
            int sqlInsertBulkSize = 1_0000;

            var comparer = new Models.Jadeh.VehicleAvlDataPatchRecoveryComparer();

            while (!ct.IsCancellationRequested && (lastDeviceTime == null || lastDeviceTime <= end))
            {
                var iterationStopwatch = Stopwatch.StartNew(); 


                var recordsRaw = await (
                    from p in _mysqlDb.TcPositions.AsNoTracking()
                    where
                        lastDeviceTime != null && p.Devicetime > lastDeviceTime && p.Devicetime <= end ||
                        lastDeviceTime == null && p.Devicetime >= start && p.Devicetime <= end
                    orderby p.Devicetime
                    select new
                    {
                        p.Id,
                        p.Deviceid,
                        p.Devicetime,
                        p.Latitude,
                        p.Longitude,
                        p.Altitude,
                        p.Speed,
                        RawAttributes = p.Attributes
                    }
                )
                .Take(mySqlQueryBatchSize)
                .ToListAsync(ct);

                if (!recordsRaw.Any())
                {
                    _logger.LogInformation("No more records to process. Exiting loop.");
                    break;
                }

                lastDeviceTime = recordsRaw.Last().Devicetime;

                _logger.LogInformation("Fetched {Count} records from MYSQL Database .. Last Devicetime: {LastDeviceTime}", recordsRaw.Count, lastDeviceTime);

                var records = recordsRaw.Select(r => new PositionDto
                {
                    id = r.Id,
                    deviceTime = r.Devicetime,
                    latitude = r.Latitude,
                    longitude = r.Longitude,
                    altitude = r.Altitude,
                    speed = r.Speed,
                    Imei = cachedDevices.TryGetValue(r.Deviceid, out var imei) ? imei : "",
                    attributes = string.IsNullOrEmpty(r.RawAttributes)
                    ? null
                    : JsonSerializer.Deserialize<PositionAttributesDto>(r.RawAttributes)
                }).ToList();
         
                //////////////////////////////this targeted for bins ///////////////////////////
                var filiteredUniqueRecords = records.Where(x =>
                           x.attributes.io109.Length > 10 && x.attributes.io109.Length < 30).DistinctBy(x=>x.attributes.io109);

                var bulkList = filiteredUniqueRecords.Select(dto =>
                {
                    var vehicleId = cachedVehicles.TryGetValue(dto.Imei, out var vId) ? vId : Guid.Empty;

                    var record = new VehicleAvlTrackingConsumer.Models.VehicleAvlDataPatchRecovery
                    {
                        Id = Guid.NewGuid(),
                        Imei = dto.Imei,
                        Speed = dto.speed,
                        Tag = dto.attributes.io109,
                        Latitude = dto.latitude,
                        Longitude = dto.longitude,
                        MovementTime = dto.deviceTime,
                        CreatedDate = DateTime.UtcNow,
                        Createdby = "API/Worker",
                        TenantId = Guid.Parse("10000001-1001-1001-1001-100000000001"),
                        VehicleId = vehicleId,
                        IsDeleted = false
                    };

                    //// Log each record to console
                    //_logger.LogInformation(
                    //    "Record prepared: Id={Id}, Imei={Imei}, Speed={Speed}, Tag={Tag}, Lat={Lat}, Lng={Lng}, VehicleId={VehicleId} , MovementTime={MovementTime}",
                    //    record.Id, record.Imei, record.Speed, record.Tag, record.Latitude, record.Longitude, record.VehicleId,record.MovementTime
                    //);

                    return record;
                }).ToHashSet(comparer);

                _logger.LogInformation("Prepared {Count} unique records for bulk insert", bulkList.Count);


                using var scope = _scopeFactory.CreateScope();
                var jadehDb = scope.ServiceProvider.GetRequiredService<JadehDbContext>();



                var bulkConfig = new BulkConfig
                {
                    BatchSize = sqlInsertBulkSize,
                    PreserveInsertOrder = false,
                    SetOutputIdentity = false,
                    UseTempDB = false,
                    BulkCopyTimeout = 600,
                };


                await jadehDb.BulkInsertAsync(bulkList, bulkConfig, null, null, ct);

                _logger.LogInformation("INSERTED RECORDS INTO RECOVER TABLE IS  {Count} unique records for bulk insert", bulkList.Count);



                // e.g., run SP every hour
                var iterationStopwatch02 = Stopwatch.StartNew();


                var finishedParam = new Microsoft.Data.SqlClient.SqlParameter("@FinishedFlag", System.Data.SqlDbType.Int)
                {
                    Direction = System.Data.ParameterDirection.Output
                };


                await jadehDb.Database.ExecuteSqlRawAsync("EXEC dbo.Dynamic_Process_Recovery_v2 @FinishedFlag OUTPUT", finishedParam);

                int finishedFlag = (int)finishedParam.Value;

                if (finishedFlag == 1)
                {
                    _logger.LogInformation("Stored procedure finished successfully.");
                }
                else
                {
                    _logger.LogError("Stored procedure failed.");
                }

                iterationStopwatch02.Stop();

                var elapsed02 = iterationStopwatch02.Elapsed;
                _logger.LogInformation("SP ______ completed in {Hours}h {Minutes}m {Seconds}s", elapsed02.Hours, elapsed02.Minutes, elapsed02.Seconds);

                iterationStopwatch.Stop();

                _logger.LogInformation("Inserted {Count} records into Jadeh DB. Last Devicetime: {LastDeviceTime}", bulkList.Count, lastDeviceTime);

                var elapsed = iterationStopwatch.Elapsed;
                _logger.LogInformation("Iteration completed in {Hours}h {Minutes}m {Seconds}s", elapsed.Hours, elapsed.Minutes, elapsed.Seconds);


            }
            mainStopwatch.Stop();
            var mainElapsed = mainStopwatch.Elapsed;
            _logger.LogInformation("whole process  _*_*_*_*_*_ completed in {Hours}h {Minutes}m {Seconds}s", mainElapsed.Hours, mainElapsed.Minutes, mainElapsed.Seconds);

        }
        catch (Exception ex)
        {
            throw new VehicleAvlProcessingException(
                "Error during AVL processing", ex, lastDeviceTime);
        }
    }
}
