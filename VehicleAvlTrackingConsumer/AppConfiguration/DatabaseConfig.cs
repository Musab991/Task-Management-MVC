using Microsoft.EntityFrameworkCore;
using VehicleAvlTrackingConsumer.Models;
using VehicleAvlTrackingConsumer.Models.Jadeh;
using VehicleAvlTrackingConsumer.Models.Jadeh_Development;
using VehicleAvlTrackingConsumer.Models.VehicleAvl;

namespace VehicleAvlTrackingConsumer.Configuration
{
    public static class DatabaseConfig
    {
        public static void AddDatabaseServices(
            this IServiceCollection services, IConfiguration config)
        {
            var mysqlConn = config.GetConnectionString("VehicleAvlTrackingMySql");
            services.AddDbContext<VehicleAvlTrackingDbContext>(options =>
            {


                options.UseMySql(
                    mysqlConn,
                    ServerVersion.AutoDetect(mysqlConn),
                    mySqlOptions =>
                    {
                        mySqlOptions.CommandTimeout(1000)
                        .EnableRetryOnFailure();
                    });

            });

            var jadehConn = config.GetConnectionString("Jadeh");
            services.AddDbContext<JadehDbContext>(options => {
                options.UseSqlServer(
                    jadehConn,
                    sqlServerOptions =>
                    {
                        sqlServerOptions.CommandTimeout(1000);
                    });


            });

        var jadehDevelopmentsConn = config.GetConnectionString("JadehDev22");
            services.AddDbContext<JadehDevelopmentDbContext>(options =>
            {
                options.UseSqlServer(
                    jadehConn,
                    sqlServerOptions =>
                    {
                        sqlServerOptions.CommandTimeout(300);
                    });


            });
            var jadehQaConn = config.GetConnectionString("JadehQa22");
            services.AddDbContext<JadehQaDbContext>(options =>
            {
                options.UseSqlServer(
                    jadehConn,
                    sqlServerOptions =>
                    {
                        sqlServerOptions.CommandTimeout(300);
                    });


            });

        }
    }
}
