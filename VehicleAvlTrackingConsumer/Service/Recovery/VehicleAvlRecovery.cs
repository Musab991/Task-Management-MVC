//namespace VehicleAvlTrackingConsumer.Service.Recovery;

//using System.Diagnostics;
//using System.Text.Json;
//using Microsoft.EntityFrameworkCore;
//using VehicleAvlTrackingConsumer.Cache;
//using VehicleAvlTrackingConsumer.Interface;
//using VehicleAvlTrackingConsumer.Models.Jadeh_Development;
//using VehicleAvlTrackingConsumer.Models.VehicleAvl;
//using VehicleAvlTrackingConsumer.Models.VehicleAvl.Dto;
//using VehicleAvlTrackingConsumer.Service.Processor;

//public class VehicleAvlRecovery : IVehicleAvlRecovery
//{

//    private readonly ILogger<VehicleAvlProcessor> _logger;
//    private readonly VehicleAvlTrackingDbContext _mysqlDb;
//    private readonly IServiceScopeFactory _scopeFactory;
//    private readonly VehicleCache _vehicleCache;
//    private readonly DeviceCache _deviceCache;
//    public VehicleAvlRecovery(ILogger<VehicleAvlProcessor> logger, VehicleAvlTrackingDbContext mysqlDb, IServiceScopeFactory scopeFactory, VehicleCache vehicleCache, DeviceCache deviceCache)
//    {
//        _logger = logger;
//        _mysqlDb = mysqlDb;
//        _scopeFactory = scopeFactory;
//        _vehicleCache = vehicleCache;
//        _deviceCache = deviceCache;
//    }

//    public async Task ProcessAsync(DateTime start, DateTime end, CancellationToken ct)
//    {
//        try
//        {   //my sql query with unique  tags for specific  among start and end   Tag,
//            //    MovementTime,
//            //VehicleId,
//            //IMEI, 
//            /*
//             * WHERE LEN(Tag) <= 255
//             * AND Tag <> '-1'
//             * AND MovementTime >= @DayOfRecovery
//             * INSERT INTO  #DetailsMatchedValidTag ... 
//             */
//            //Longitude,
//            //Latitude
//            //tag != -1 and length <=255 and length>20
//            //
//            //
//            // get trips matched within this tag..  and avl.MovementTime BETWEEN t.StartTrip AND t.EndTrip
//            // bring 4 table realated (tr,tripdateail,process x2)
//            /// update trips details ... 
//            /// update bins 
//            /// update trip details processing summary
//            /// 
//            /*
//              VehicleId=dm.VehicleId,
//       TrackingDeviceNumber=dm.Imei,
//       BinLongitude=dm.BinLongitude,
//       BinLatitude=dm.BinLatitude,
//       ModifiedBy='SP_DynamicServiceStored_recovery' ,
//       ModifiedDate=dm.MovementTime,
//        tdps.BinStatusId
//                tdps.NumberOfLefts
//            tdps.LastCompletion
//             */


//            _logger.LogInformation("Vehicle AVL Recovery started from {Start} to {End}", start, end);
//            bool isThereRecordExists = true;
//            int mySqlQueryBatchSize = 300_000;
//            var cachedVehicles = _vehicleCache.GetVehicles();
//            var cachedDevices = _deviceCache.GetDevices();
//            var comparer = new VehicleAvlDatumComparer();
//            DateTime? lastDeviceTime = null; 

//            while (!ct.IsCancellationRequested && isThereRecordExists)
//            {
//                var iterationStopwatch = Stopwatch.StartNew();


//                var recordsRaw = await (
//                    from p in _mysqlDb.TcPositions.AsNoTracking()
//                    where
//                        lastDeviceTime != null && p.Devicetime > lastDeviceTime && p.Devicetime <= end ||
//                        lastDeviceTime == null && p.Devicetime >= start && p.Devicetime <= end
//                    orderby p.Devicetime
//                    select new
//                    {
//                        p.Id,
//                        p.Deviceid,
//                        p.Devicetime,
//                        p.Latitude,
//                        p.Longitude,
//                        p.Altitude,
//                        p.Speed,
//                        RawAttributes = p.Attributes
//                    }
//                )
//                .Take(mySqlQueryBatchSize)
//                .ToListAsync(ct);
               
//                if (!recordsRaw.Any())
//                {
//                    _logger.LogInformation("No more records to process. Exiting loop.");
//                    break;
//                }
                
//                lastDeviceTime = recordsRaw.Last().Devicetime;


//                _logger.LogInformation("Fetched {Count} records from MYSQL Database .. Last Devicetime: {LastDeviceTime}", recordsRaw.Count, lastDeviceTime);

//                var records = recordsRaw.Select(r => new PositionDto
//                {
//                    id = r.Id,
//                    deviceTime = r.Devicetime,
//                    latitude = r.Latitude,
//                    longitude = r.Longitude,
//                    altitude = r.Altitude,
//                    speed = r.Speed,
//                    Imei = cachedDevices.TryGetValue(r.Deviceid, out var imei) ? imei : "",
//                    attributes = string.IsNullOrEmpty(r.RawAttributes)
//                    ? null
//                    : JsonSerializer.Deserialize<PositionAttributesDto>(r.RawAttributes)
//                }).ToList();


//                var filiteredUniqueRecords = records.Where(x =>
//                x.attributes.io109.Length > 20 && x.attributes.io109.Length < 100);


//            }



//        }
//        catch (Exception ex)
//        {
//            throw ex;
//        }
     

//        throw new NotImplementedException();
//    }

//}

