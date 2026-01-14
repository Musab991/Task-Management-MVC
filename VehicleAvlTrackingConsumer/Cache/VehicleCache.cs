using System.Collections.Concurrent;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using VehicleAvlTrackingConsumer.Models.Jadeh;
using VehicleAvlTrackingConsumer.Models.VehicleAvl;

namespace VehicleAvlTrackingConsumer.Cache
{
    public class VehicleCache
    {
        private readonly IMemoryCache _cache;
        private readonly IServiceProvider _provider;

        public VehicleCache(IMemoryCache cache, IServiceProvider provider)
        {
            _cache = cache;
            _provider = provider;
        }

        public ConcurrentDictionary<string, Guid> GetVehicles()
        {
            return _cache.GetOrCreate("vehicles-cache", entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(10);

                var dict = new ConcurrentDictionary<string, Guid>();

                using var scope = _provider.CreateScope();
                var context = scope.ServiceProvider.GetRequiredService<JadehDbContext>();

                var vehicles = context.Vehicles
                                      .AsNoTracking()
                                      .Select(v => new { v.TrackingDeviceNumber, v.Id })
                                      .ToList();

                foreach (var v in vehicles)
                {
                    dict.TryAdd(v.TrackingDeviceNumber.ToString(), v.Id);
                }

                return dict;
            });
        }
    }

    public class DeviceCache
    {
        private readonly IMemoryCache _cache;
        private readonly IServiceProvider _provider;

        public DeviceCache(IMemoryCache cache, IServiceProvider provider)
        {
            _cache = cache;
            _provider = provider;
        }

        public ConcurrentDictionary<int, string> GetDevices()
        {
            return _cache.GetOrCreate("devices-cache", entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(10);

                var dict = new ConcurrentDictionary<int, string>();

                using (var scope = _provider.CreateScope())
                {

                    var mysqlDb = scope.ServiceProvider.GetRequiredService<VehicleAvlTrackingDbContext>();

                    var vehicles = mysqlDb.TcDevices
                                      .AsNoTracking()
                                      .Select(v => new { v.Id, v.Uniqueid })
                                      .ToList();

                    foreach (var v in vehicles)
                    {
                        dict.TryAdd(v.Id, v.Uniqueid);
                    }

                    return dict;
                }

            });
        }
    
    }


}
