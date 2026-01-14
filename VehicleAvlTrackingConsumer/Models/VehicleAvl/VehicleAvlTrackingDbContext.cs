using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.VehicleAvl;

public partial class VehicleAvlTrackingDbContext : DbContext
{
    public VehicleAvlTrackingDbContext()
    {
    }

    public VehicleAvlTrackingDbContext(DbContextOptions<VehicleAvlTrackingDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Databasechangelog> Databasechangelogs { get; set; }

    public virtual DbSet<Databasechangeloglock> Databasechangeloglocks { get; set; }

    public virtual DbSet<TcAction> TcActions { get; set; }

    public virtual DbSet<TcAttribute> TcAttributes { get; set; }

    public virtual DbSet<TcCalendar> TcCalendars { get; set; }

    public virtual DbSet<TcCommand> TcCommands { get; set; }

    public virtual DbSet<TcCommandsQueue> TcCommandsQueues { get; set; }

    public virtual DbSet<TcDevice> TcDevices { get; set; }

    public virtual DbSet<TcDriver> TcDrivers { get; set; }

    public virtual DbSet<TcEvent> TcEvents { get; set; }

    public virtual DbSet<TcGeofence> TcGeofences { get; set; }

    public virtual DbSet<TcGroup> TcGroups { get; set; }

    public virtual DbSet<TcKeystore> TcKeystores { get; set; }

    public virtual DbSet<TcMaintenance> TcMaintenances { get; set; }

    public virtual DbSet<TcNotification> TcNotifications { get; set; }

    public virtual DbSet<TcOrder> TcOrders { get; set; }

    public virtual DbSet<TcPosition> TcPositions { get; set; }

    public virtual DbSet<TcReport> TcReports { get; set; }

    public virtual DbSet<TcServer> TcServers { get; set; }

    public virtual DbSet<TcStatistic> TcStatistics { get; set; }

    public virtual DbSet<TcUser> TcUsers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=127.0.0.1;port=3307;database=jed-trac;user=bayan;password=RXVM4u#9M", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.4.4-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Databasechangelog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<Databasechangeloglock>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<TcAction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<TcAttribute>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<TcCalendar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<TcCommand>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.Property(e => e.Textchannel).HasDefaultValueSql("b'0'");
        });

        modelBuilder.Entity<TcCommandsQueue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.Property(e => e.Textchannel).HasDefaultValueSql("b'0'");

            entity.HasOne(d => d.Device).WithMany(p => p.TcCommandsQueues).HasConstraintName("fk_commands_queue_deviceid");
        });

        modelBuilder.Entity<TcDevice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.Property(e => e.Disabled).HasDefaultValueSql("b'0'");
            entity.Property(e => e.Motiondistance).HasDefaultValueSql("'0'");
            entity.Property(e => e.Motionstate).HasDefaultValueSql("b'0'");
            entity.Property(e => e.Motionstreak).HasDefaultValueSql("b'0'");
            entity.Property(e => e.Overspeedgeofenceid).HasDefaultValueSql("'0'");
            entity.Property(e => e.Overspeedstate).HasDefaultValueSql("b'0'");
            entity.Property(e => e.Status).IsFixedLength();

            entity.HasOne(d => d.Calendar).WithMany(p => p.TcDevices)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fk_devices_calendarid");

            entity.HasOne(d => d.Group).WithMany(p => p.TcDevices)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fk_devices_groupid");

            entity.HasMany(d => d.AttributesNavigation).WithMany(p => p.Devices)
                .UsingEntity<Dictionary<string, object>>(
                    "TcDeviceAttribute",
                    r => r.HasOne<TcAttribute>().WithMany()
                        .HasForeignKey("Attributeid")
                        .HasConstraintName("fk_user_device_attribute_attributeid"),
                    l => l.HasOne<TcDevice>().WithMany()
                        .HasForeignKey("Deviceid")
                        .HasConstraintName("fk_user_device_attribute_deviceid"),
                    j =>
                    {
                        j.HasKey("Deviceid", "Attributeid")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j
                            .ToTable("tc_device_attribute")
                            .HasCharSet("utf8mb3")
                            .UseCollation("utf8mb3_general_ci");
                        j.HasIndex(new[] { "Attributeid" }, "fk_user_device_attribute_attributeid");
                        j.HasIndex(new[] { "Deviceid" }, "fk_user_device_attribute_deviceid");
                        j.IndexerProperty<int>("Deviceid").HasColumnName("deviceid");
                        j.IndexerProperty<int>("Attributeid").HasColumnName("attributeid");
                    });

            entity.HasMany(d => d.Commands).WithMany(p => p.Devices)
                .UsingEntity<Dictionary<string, object>>(
                    "TcDeviceCommand",
                    r => r.HasOne<TcCommand>().WithMany()
                        .HasForeignKey("Commandid")
                        .HasConstraintName("fk_device_command_commandid"),
                    l => l.HasOne<TcDevice>().WithMany()
                        .HasForeignKey("Deviceid")
                        .HasConstraintName("fk_device_command_deviceid"),
                    j =>
                    {
                        j.HasKey("Deviceid", "Commandid")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j
                            .ToTable("tc_device_command")
                            .HasCharSet("utf8mb3")
                            .UseCollation("utf8mb3_general_ci");
                        j.HasIndex(new[] { "Commandid" }, "fk_device_command_commandid");
                        j.HasIndex(new[] { "Deviceid" }, "fk_device_command_deviceid");
                        j.IndexerProperty<int>("Deviceid").HasColumnName("deviceid");
                        j.IndexerProperty<int>("Commandid").HasColumnName("commandid");
                    });

            entity.HasMany(d => d.Drivers).WithMany(p => p.Devices)
                .UsingEntity<Dictionary<string, object>>(
                    "TcDeviceDriver",
                    r => r.HasOne<TcDriver>().WithMany()
                        .HasForeignKey("Driverid")
                        .HasConstraintName("fk_device_driver_driverid"),
                    l => l.HasOne<TcDevice>().WithMany()
                        .HasForeignKey("Deviceid")
                        .HasConstraintName("fk_device_driver_deviceid"),
                    j =>
                    {
                        j.HasKey("Deviceid", "Driverid")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j
                            .ToTable("tc_device_driver")
                            .HasCharSet("utf8mb3")
                            .UseCollation("utf8mb3_general_ci");
                        j.HasIndex(new[] { "Deviceid" }, "fk_device_driver_deviceid");
                        j.HasIndex(new[] { "Driverid" }, "fk_device_driver_driverid");
                        j.IndexerProperty<int>("Deviceid").HasColumnName("deviceid");
                        j.IndexerProperty<int>("Driverid").HasColumnName("driverid");
                    });

            entity.HasMany(d => d.Geofences).WithMany(p => p.Devices)
                .UsingEntity<Dictionary<string, object>>(
                    "TcDeviceGeofence",
                    r => r.HasOne<TcGeofence>().WithMany()
                        .HasForeignKey("Geofenceid")
                        .HasConstraintName("fk_device_geofence_geofenceid"),
                    l => l.HasOne<TcDevice>().WithMany()
                        .HasForeignKey("Deviceid")
                        .HasConstraintName("fk_device_geofence_deviceid"),
                    j =>
                    {
                        j.HasKey("Deviceid", "Geofenceid")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j
                            .ToTable("tc_device_geofence")
                            .HasCharSet("utf8mb3")
                            .UseCollation("utf8mb3_general_ci");
                        j.HasIndex(new[] { "Deviceid" }, "fk_device_geofence_deviceid");
                        j.HasIndex(new[] { "Geofenceid" }, "fk_device_geofence_geofenceid");
                        j.IndexerProperty<int>("Deviceid").HasColumnName("deviceid");
                        j.IndexerProperty<int>("Geofenceid").HasColumnName("geofenceid");
                    });

            entity.HasMany(d => d.Maintenances).WithMany(p => p.Devices)
                .UsingEntity<Dictionary<string, object>>(
                    "TcDeviceMaintenance",
                    r => r.HasOne<TcMaintenance>().WithMany()
                        .HasForeignKey("Maintenanceid")
                        .HasConstraintName("fk_device_maintenance_maintenanceid"),
                    l => l.HasOne<TcDevice>().WithMany()
                        .HasForeignKey("Deviceid")
                        .HasConstraintName("fk_device_maintenance_deviceid"),
                    j =>
                    {
                        j.HasKey("Deviceid", "Maintenanceid")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j
                            .ToTable("tc_device_maintenance")
                            .HasCharSet("utf8mb3")
                            .UseCollation("utf8mb3_general_ci");
                        j.HasIndex(new[] { "Deviceid" }, "fk_device_maintenance_deviceid");
                        j.HasIndex(new[] { "Maintenanceid" }, "fk_device_maintenance_maintenanceid");
                        j.IndexerProperty<int>("Deviceid").HasColumnName("deviceid");
                        j.IndexerProperty<int>("Maintenanceid").HasColumnName("maintenanceid");
                    });

            entity.HasMany(d => d.Notifications).WithMany(p => p.Devices)
                .UsingEntity<Dictionary<string, object>>(
                    "TcDeviceNotification",
                    r => r.HasOne<TcNotification>().WithMany()
                        .HasForeignKey("Notificationid")
                        .HasConstraintName("fk_device_notification_notificationid"),
                    l => l.HasOne<TcDevice>().WithMany()
                        .HasForeignKey("Deviceid")
                        .HasConstraintName("fk_device_notification_deviceid"),
                    j =>
                    {
                        j.HasKey("Deviceid", "Notificationid")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j
                            .ToTable("tc_device_notification")
                            .HasCharSet("utf8mb3")
                            .UseCollation("utf8mb3_general_ci");
                        j.HasIndex(new[] { "Deviceid" }, "fk_device_notification_deviceid");
                        j.HasIndex(new[] { "Notificationid" }, "fk_device_notification_notificationid");
                        j.IndexerProperty<int>("Deviceid").HasColumnName("deviceid");
                        j.IndexerProperty<int>("Notificationid").HasColumnName("notificationid");
                    });

            entity.HasMany(d => d.Orders).WithMany(p => p.Devices)
                .UsingEntity<Dictionary<string, object>>(
                    "TcDeviceOrder",
                    r => r.HasOne<TcOrder>().WithMany()
                        .HasForeignKey("Orderid")
                        .HasConstraintName("fk_device_order_orderid"),
                    l => l.HasOne<TcDevice>().WithMany()
                        .HasForeignKey("Deviceid")
                        .HasConstraintName("fk_device_order_deviceid"),
                    j =>
                    {
                        j.HasKey("Deviceid", "Orderid")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j
                            .ToTable("tc_device_order")
                            .HasCharSet("utf8mb3")
                            .UseCollation("utf8mb3_general_ci");
                        j.HasIndex(new[] { "Deviceid" }, "fk_device_order_deviceid");
                        j.HasIndex(new[] { "Orderid" }, "fk_device_order_orderid");
                        j.IndexerProperty<int>("Deviceid").HasColumnName("deviceid");
                        j.IndexerProperty<int>("Orderid").HasColumnName("orderid");
                    });

            entity.HasMany(d => d.Reports).WithMany(p => p.Devices)
                .UsingEntity<Dictionary<string, object>>(
                    "TcDeviceReport",
                    r => r.HasOne<TcReport>().WithMany()
                        .HasForeignKey("Reportid")
                        .HasConstraintName("fk_device_report_reportid"),
                    l => l.HasOne<TcDevice>().WithMany()
                        .HasForeignKey("Deviceid")
                        .HasConstraintName("fk_device_report_deviceid"),
                    j =>
                    {
                        j.HasKey("Deviceid", "Reportid")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j
                            .ToTable("tc_device_report")
                            .HasCharSet("utf8mb3")
                            .UseCollation("utf8mb3_general_ci");
                        j.HasIndex(new[] { "Deviceid" }, "fk_device_report_deviceid");
                        j.HasIndex(new[] { "Reportid" }, "fk_device_report_reportid");
                        j.IndexerProperty<int>("Deviceid").HasColumnName("deviceid");
                        j.IndexerProperty<int>("Reportid").HasColumnName("reportid");
                    });
        });

        modelBuilder.Entity<TcDriver>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<TcEvent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<TcGeofence>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.HasOne(d => d.Calendar).WithMany(p => p.TcGeofences)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fk_geofence_calendar_calendarid");
        });

        modelBuilder.Entity<TcGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.HasOne(d => d.Group).WithMany(p => p.InverseGroup)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fk_groups_groupid");

            entity.HasMany(d => d.AttributesNavigation).WithMany(p => p.Groups)
                .UsingEntity<Dictionary<string, object>>(
                    "TcGroupAttribute",
                    r => r.HasOne<TcAttribute>().WithMany()
                        .HasForeignKey("Attributeid")
                        .HasConstraintName("fk_group_attribute_attributeid"),
                    l => l.HasOne<TcGroup>().WithMany()
                        .HasForeignKey("Groupid")
                        .HasConstraintName("fk_group_attribute_groupid"),
                    j =>
                    {
                        j.HasKey("Groupid", "Attributeid")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j
                            .ToTable("tc_group_attribute")
                            .HasCharSet("utf8mb3")
                            .UseCollation("utf8mb3_general_ci");
                        j.HasIndex(new[] { "Attributeid" }, "fk_group_attribute_attributeid");
                        j.HasIndex(new[] { "Groupid" }, "fk_group_attribute_groupid");
                        j.IndexerProperty<int>("Groupid").HasColumnName("groupid");
                        j.IndexerProperty<int>("Attributeid").HasColumnName("attributeid");
                    });

            entity.HasMany(d => d.Commands).WithMany(p => p.Groups)
                .UsingEntity<Dictionary<string, object>>(
                    "TcGroupCommand",
                    r => r.HasOne<TcCommand>().WithMany()
                        .HasForeignKey("Commandid")
                        .HasConstraintName("fk_group_command_commandid"),
                    l => l.HasOne<TcGroup>().WithMany()
                        .HasForeignKey("Groupid")
                        .HasConstraintName("fk_group_command_groupid"),
                    j =>
                    {
                        j.HasKey("Groupid", "Commandid")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j
                            .ToTable("tc_group_command")
                            .HasCharSet("utf8mb3")
                            .UseCollation("utf8mb3_general_ci");
                        j.HasIndex(new[] { "Commandid" }, "fk_group_command_commandid");
                        j.HasIndex(new[] { "Groupid" }, "fk_group_command_groupid");
                        j.IndexerProperty<int>("Groupid").HasColumnName("groupid");
                        j.IndexerProperty<int>("Commandid").HasColumnName("commandid");
                    });

            entity.HasMany(d => d.Drivers).WithMany(p => p.Groups)
                .UsingEntity<Dictionary<string, object>>(
                    "TcGroupDriver",
                    r => r.HasOne<TcDriver>().WithMany()
                        .HasForeignKey("Driverid")
                        .HasConstraintName("fk_group_driver_driverid"),
                    l => l.HasOne<TcGroup>().WithMany()
                        .HasForeignKey("Groupid")
                        .HasConstraintName("fk_group_driver_groupid"),
                    j =>
                    {
                        j.HasKey("Groupid", "Driverid")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j
                            .ToTable("tc_group_driver")
                            .HasCharSet("utf8mb3")
                            .UseCollation("utf8mb3_general_ci");
                        j.HasIndex(new[] { "Driverid" }, "fk_group_driver_driverid");
                        j.HasIndex(new[] { "Groupid" }, "fk_group_driver_groupid");
                        j.IndexerProperty<int>("Groupid").HasColumnName("groupid");
                        j.IndexerProperty<int>("Driverid").HasColumnName("driverid");
                    });

            entity.HasMany(d => d.Geofences).WithMany(p => p.Groups)
                .UsingEntity<Dictionary<string, object>>(
                    "TcGroupGeofence",
                    r => r.HasOne<TcGeofence>().WithMany()
                        .HasForeignKey("Geofenceid")
                        .HasConstraintName("fk_group_geofence_geofenceid"),
                    l => l.HasOne<TcGroup>().WithMany()
                        .HasForeignKey("Groupid")
                        .HasConstraintName("fk_group_geofence_groupid"),
                    j =>
                    {
                        j.HasKey("Groupid", "Geofenceid")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j
                            .ToTable("tc_group_geofence")
                            .HasCharSet("utf8mb3")
                            .UseCollation("utf8mb3_general_ci");
                        j.HasIndex(new[] { "Geofenceid" }, "fk_group_geofence_geofenceid");
                        j.HasIndex(new[] { "Groupid" }, "fk_group_geofence_groupid");
                        j.IndexerProperty<int>("Groupid").HasColumnName("groupid");
                        j.IndexerProperty<int>("Geofenceid").HasColumnName("geofenceid");
                    });

            entity.HasMany(d => d.Maintenances).WithMany(p => p.Groups)
                .UsingEntity<Dictionary<string, object>>(
                    "TcGroupMaintenance",
                    r => r.HasOne<TcMaintenance>().WithMany()
                        .HasForeignKey("Maintenanceid")
                        .HasConstraintName("fk_group_maintenance_maintenanceid"),
                    l => l.HasOne<TcGroup>().WithMany()
                        .HasForeignKey("Groupid")
                        .HasConstraintName("fk_group_maintenance_groupid"),
                    j =>
                    {
                        j.HasKey("Groupid", "Maintenanceid")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j
                            .ToTable("tc_group_maintenance")
                            .HasCharSet("utf8mb3")
                            .UseCollation("utf8mb3_general_ci");
                        j.HasIndex(new[] { "Groupid" }, "fk_group_maintenance_groupid");
                        j.HasIndex(new[] { "Maintenanceid" }, "fk_group_maintenance_maintenanceid");
                        j.IndexerProperty<int>("Groupid").HasColumnName("groupid");
                        j.IndexerProperty<int>("Maintenanceid").HasColumnName("maintenanceid");
                    });

            entity.HasMany(d => d.Notifications).WithMany(p => p.Groups)
                .UsingEntity<Dictionary<string, object>>(
                    "TcGroupNotification",
                    r => r.HasOne<TcNotification>().WithMany()
                        .HasForeignKey("Notificationid")
                        .HasConstraintName("fk_group_notification_notificationid"),
                    l => l.HasOne<TcGroup>().WithMany()
                        .HasForeignKey("Groupid")
                        .HasConstraintName("fk_group_notification_groupid"),
                    j =>
                    {
                        j.HasKey("Groupid", "Notificationid")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j
                            .ToTable("tc_group_notification")
                            .HasCharSet("utf8mb3")
                            .UseCollation("utf8mb3_general_ci");
                        j.HasIndex(new[] { "Groupid" }, "fk_group_notification_groupid");
                        j.HasIndex(new[] { "Notificationid" }, "fk_group_notification_notificationid");
                        j.IndexerProperty<int>("Groupid").HasColumnName("groupid");
                        j.IndexerProperty<int>("Notificationid").HasColumnName("notificationid");
                    });

            entity.HasMany(d => d.Orders).WithMany(p => p.Groups)
                .UsingEntity<Dictionary<string, object>>(
                    "TcGroupOrder",
                    r => r.HasOne<TcOrder>().WithMany()
                        .HasForeignKey("Orderid")
                        .HasConstraintName("fk_group_order_orderid"),
                    l => l.HasOne<TcGroup>().WithMany()
                        .HasForeignKey("Groupid")
                        .HasConstraintName("fk_group_order_groupid"),
                    j =>
                    {
                        j.HasKey("Groupid", "Orderid")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j
                            .ToTable("tc_group_order")
                            .HasCharSet("utf8mb3")
                            .UseCollation("utf8mb3_general_ci");
                        j.HasIndex(new[] { "Groupid" }, "fk_group_order_groupid");
                        j.HasIndex(new[] { "Orderid" }, "fk_group_order_orderid");
                        j.IndexerProperty<int>("Groupid").HasColumnName("groupid");
                        j.IndexerProperty<int>("Orderid").HasColumnName("orderid");
                    });

            entity.HasMany(d => d.Reports).WithMany(p => p.Groups)
                .UsingEntity<Dictionary<string, object>>(
                    "TcGroupReport",
                    r => r.HasOne<TcReport>().WithMany()
                        .HasForeignKey("Reportid")
                        .HasConstraintName("fk_group_report_reportid"),
                    l => l.HasOne<TcGroup>().WithMany()
                        .HasForeignKey("Groupid")
                        .HasConstraintName("fk_group_report_groupid"),
                    j =>
                    {
                        j.HasKey("Groupid", "Reportid")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j
                            .ToTable("tc_group_report")
                            .HasCharSet("utf8mb3")
                            .UseCollation("utf8mb3_general_ci");
                        j.HasIndex(new[] { "Groupid" }, "fk_group_report_groupid");
                        j.HasIndex(new[] { "Reportid" }, "fk_group_report_reportid");
                        j.IndexerProperty<int>("Groupid").HasColumnName("groupid");
                        j.IndexerProperty<int>("Reportid").HasColumnName("reportid");
                    });
        });

        modelBuilder.Entity<TcKeystore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<TcMaintenance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<TcNotification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.Property(e => e.Always).HasDefaultValueSql("b'0'");

            entity.HasOne(d => d.Calendar).WithMany(p => p.TcNotifications)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fk_notification_calendar_calendarid");

            entity.HasOne(d => d.Command).WithMany(p => p.TcNotifications)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_notifications_commandid");
        });

        modelBuilder.Entity<TcOrder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<TcPosition>(entity =>
        {
            entity.HasKey(e => new { e.Devicetime, e.Id })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Servertime).HasDefaultValueSql("CURRENT_TIMESTAMP");
        });

        modelBuilder.Entity<TcReport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.HasOne(d => d.Calendar).WithMany(p => p.TcReports).HasConstraintName("fk_reports_calendarid");
        });

        modelBuilder.Entity<TcServer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.Property(e => e.Devicereadonly).HasDefaultValueSql("b'0'");
            entity.Property(e => e.Disablereports).HasDefaultValueSql("b'0'");
            entity.Property(e => e.Fixedemail).HasDefaultValueSql("b'0'");
            entity.Property(e => e.Forcesettings).HasDefaultValueSql("b'0'");
            entity.Property(e => e.Limitcommands).HasDefaultValueSql("b'0'");
            entity.Property(e => e.Readonly).HasDefaultValueSql("b'0'");
            entity.Property(e => e.Registration).HasDefaultValueSql("b'1'");
        });

        modelBuilder.Entity<TcStatistic>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");
        });

        modelBuilder.Entity<TcUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.Property(e => e.Devicelimit).HasDefaultValueSql("'-1'");
            entity.Property(e => e.Devicereadonly).HasDefaultValueSql("b'0'");
            entity.Property(e => e.Disabled).HasDefaultValueSql("b'0'");
            entity.Property(e => e.Disablereports).HasDefaultValueSql("b'0'");
            entity.Property(e => e.Fixedemail).HasDefaultValueSql("b'0'");
            entity.Property(e => e.Limitcommands).HasDefaultValueSql("b'0'");
            entity.Property(e => e.Readonly).HasDefaultValueSql("b'0'");
            entity.Property(e => e.Userlimit).HasDefaultValueSql("'0'");

            entity.HasMany(d => d.AttributesNavigation).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "TcUserAttribute",
                    r => r.HasOne<TcAttribute>().WithMany()
                        .HasForeignKey("Attributeid")
                        .HasConstraintName("fk_user_attribute_attributeid"),
                    l => l.HasOne<TcUser>().WithMany()
                        .HasForeignKey("Userid")
                        .HasConstraintName("fk_user_attribute_userid"),
                    j =>
                    {
                        j.HasKey("Userid", "Attributeid")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j
                            .ToTable("tc_user_attribute")
                            .HasCharSet("utf8mb3")
                            .UseCollation("utf8mb3_general_ci");
                        j.HasIndex(new[] { "Attributeid" }, "fk_user_attribute_attributeid");
                        j.HasIndex(new[] { "Userid" }, "fk_user_attribute_userid");
                        j.IndexerProperty<int>("Userid").HasColumnName("userid");
                        j.IndexerProperty<int>("Attributeid").HasColumnName("attributeid");
                    });

            entity.HasMany(d => d.Calendars).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "TcUserCalendar",
                    r => r.HasOne<TcCalendar>().WithMany()
                        .HasForeignKey("Calendarid")
                        .HasConstraintName("fk_user_calendar_calendarid"),
                    l => l.HasOne<TcUser>().WithMany()
                        .HasForeignKey("Userid")
                        .HasConstraintName("fk_user_calendar_userid"),
                    j =>
                    {
                        j.HasKey("Userid", "Calendarid")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j
                            .ToTable("tc_user_calendar")
                            .HasCharSet("utf8mb3")
                            .UseCollation("utf8mb3_general_ci");
                        j.HasIndex(new[] { "Calendarid" }, "fk_user_calendar_calendarid");
                        j.HasIndex(new[] { "Userid" }, "fk_user_calendar_userid");
                        j.IndexerProperty<int>("Userid").HasColumnName("userid");
                        j.IndexerProperty<int>("Calendarid").HasColumnName("calendarid");
                    });

            entity.HasMany(d => d.Commands).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "TcUserCommand",
                    r => r.HasOne<TcCommand>().WithMany()
                        .HasForeignKey("Commandid")
                        .HasConstraintName("fk_user_command_commandid"),
                    l => l.HasOne<TcUser>().WithMany()
                        .HasForeignKey("Userid")
                        .HasConstraintName("fk_user_command_userid"),
                    j =>
                    {
                        j.HasKey("Userid", "Commandid")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j
                            .ToTable("tc_user_command")
                            .HasCharSet("utf8mb3")
                            .UseCollation("utf8mb3_general_ci");
                        j.HasIndex(new[] { "Commandid" }, "fk_user_command_commandid");
                        j.HasIndex(new[] { "Userid" }, "fk_user_command_userid");
                        j.IndexerProperty<int>("Userid").HasColumnName("userid");
                        j.IndexerProperty<int>("Commandid").HasColumnName("commandid");
                    });

            entity.HasMany(d => d.Devices).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "TcUserDevice",
                    r => r.HasOne<TcDevice>().WithMany()
                        .HasForeignKey("Deviceid")
                        .HasConstraintName("fk_user_device_deviceid"),
                    l => l.HasOne<TcUser>().WithMany()
                        .HasForeignKey("Userid")
                        .HasConstraintName("fk_user_device_userid"),
                    j =>
                    {
                        j.HasKey("Userid", "Deviceid")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j
                            .ToTable("tc_user_device")
                            .HasCharSet("utf8mb3")
                            .UseCollation("utf8mb3_general_ci");
                        j.HasIndex(new[] { "Deviceid" }, "fk_user_device_deviceid");
                        j.HasIndex(new[] { "Userid" }, "user_device_user_id");
                        j.IndexerProperty<int>("Userid").HasColumnName("userid");
                        j.IndexerProperty<int>("Deviceid").HasColumnName("deviceid");
                    });

            entity.HasMany(d => d.Drivers).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "TcUserDriver",
                    r => r.HasOne<TcDriver>().WithMany()
                        .HasForeignKey("Driverid")
                        .HasConstraintName("fk_user_driver_driverid"),
                    l => l.HasOne<TcUser>().WithMany()
                        .HasForeignKey("Userid")
                        .HasConstraintName("fk_user_driver_userid"),
                    j =>
                    {
                        j.HasKey("Userid", "Driverid")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j
                            .ToTable("tc_user_driver")
                            .HasCharSet("utf8mb3")
                            .UseCollation("utf8mb3_general_ci");
                        j.HasIndex(new[] { "Driverid" }, "fk_user_driver_driverid");
                        j.HasIndex(new[] { "Userid" }, "fk_user_driver_userid");
                        j.IndexerProperty<int>("Userid").HasColumnName("userid");
                        j.IndexerProperty<int>("Driverid").HasColumnName("driverid");
                    });

            entity.HasMany(d => d.Geofences).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "TcUserGeofence",
                    r => r.HasOne<TcGeofence>().WithMany()
                        .HasForeignKey("Geofenceid")
                        .HasConstraintName("fk_user_geofence_geofenceid"),
                    l => l.HasOne<TcUser>().WithMany()
                        .HasForeignKey("Userid")
                        .HasConstraintName("fk_user_geofence_userid"),
                    j =>
                    {
                        j.HasKey("Userid", "Geofenceid")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j
                            .ToTable("tc_user_geofence")
                            .HasCharSet("utf8mb3")
                            .UseCollation("utf8mb3_general_ci");
                        j.HasIndex(new[] { "Geofenceid" }, "fk_user_geofence_geofenceid");
                        j.HasIndex(new[] { "Userid" }, "fk_user_geofence_userid");
                        j.IndexerProperty<int>("Userid").HasColumnName("userid");
                        j.IndexerProperty<int>("Geofenceid").HasColumnName("geofenceid");
                    });

            entity.HasMany(d => d.Groups).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "TcUserGroup",
                    r => r.HasOne<TcGroup>().WithMany()
                        .HasForeignKey("Groupid")
                        .HasConstraintName("fk_user_group_groupid"),
                    l => l.HasOne<TcUser>().WithMany()
                        .HasForeignKey("Userid")
                        .HasConstraintName("fk_user_group_userid"),
                    j =>
                    {
                        j.HasKey("Userid", "Groupid")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j
                            .ToTable("tc_user_group")
                            .HasCharSet("utf8mb3")
                            .UseCollation("utf8mb3_general_ci");
                        j.HasIndex(new[] { "Groupid" }, "fk_user_group_groupid");
                        j.HasIndex(new[] { "Userid" }, "fk_user_group_userid");
                        j.IndexerProperty<int>("Userid").HasColumnName("userid");
                        j.IndexerProperty<int>("Groupid").HasColumnName("groupid");
                    });

            entity.HasMany(d => d.Maintenances).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "TcUserMaintenance",
                    r => r.HasOne<TcMaintenance>().WithMany()
                        .HasForeignKey("Maintenanceid")
                        .HasConstraintName("fk_user_maintenance_maintenanceid"),
                    l => l.HasOne<TcUser>().WithMany()
                        .HasForeignKey("Userid")
                        .HasConstraintName("fk_user_maintenance_userid"),
                    j =>
                    {
                        j.HasKey("Userid", "Maintenanceid")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j
                            .ToTable("tc_user_maintenance")
                            .HasCharSet("utf8mb3")
                            .UseCollation("utf8mb3_general_ci");
                        j.HasIndex(new[] { "Maintenanceid" }, "fk_user_maintenance_maintenanceid");
                        j.HasIndex(new[] { "Userid" }, "fk_user_maintenance_userid");
                        j.IndexerProperty<int>("Userid").HasColumnName("userid");
                        j.IndexerProperty<int>("Maintenanceid").HasColumnName("maintenanceid");
                    });

            entity.HasMany(d => d.Managedusers).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "TcUserUser",
                    r => r.HasOne<TcUser>().WithMany()
                        .HasForeignKey("Manageduserid")
                        .HasConstraintName("fk_user_user_manageduserid"),
                    l => l.HasOne<TcUser>().WithMany()
                        .HasForeignKey("Userid")
                        .HasConstraintName("fk_user_user_userid"),
                    j =>
                    {
                        j.HasKey("Userid", "Manageduserid")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j
                            .ToTable("tc_user_user")
                            .HasCharSet("utf8mb3")
                            .UseCollation("utf8mb3_general_ci");
                        j.HasIndex(new[] { "Manageduserid" }, "fk_user_user_manageduserid");
                        j.HasIndex(new[] { "Userid" }, "fk_user_user_userid");
                        j.IndexerProperty<int>("Userid").HasColumnName("userid");
                        j.IndexerProperty<int>("Manageduserid").HasColumnName("manageduserid");
                    });

            entity.HasMany(d => d.Notifications).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "TcUserNotification",
                    r => r.HasOne<TcNotification>().WithMany()
                        .HasForeignKey("Notificationid")
                        .HasConstraintName("fk_user_notification_notificationid"),
                    l => l.HasOne<TcUser>().WithMany()
                        .HasForeignKey("Userid")
                        .HasConstraintName("fk_user_notification_userid"),
                    j =>
                    {
                        j.HasKey("Userid", "Notificationid")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j
                            .ToTable("tc_user_notification")
                            .HasCharSet("utf8mb3")
                            .UseCollation("utf8mb3_general_ci");
                        j.HasIndex(new[] { "Notificationid" }, "fk_user_notification_notificationid");
                        j.HasIndex(new[] { "Userid" }, "fk_user_notification_userid");
                        j.IndexerProperty<int>("Userid").HasColumnName("userid");
                        j.IndexerProperty<int>("Notificationid").HasColumnName("notificationid");
                    });

            entity.HasMany(d => d.Orders).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "TcUserOrder",
                    r => r.HasOne<TcOrder>().WithMany()
                        .HasForeignKey("Orderid")
                        .HasConstraintName("fk_user_order_orderid"),
                    l => l.HasOne<TcUser>().WithMany()
                        .HasForeignKey("Userid")
                        .HasConstraintName("fk_user_order_userid"),
                    j =>
                    {
                        j.HasKey("Userid", "Orderid")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j
                            .ToTable("tc_user_order")
                            .HasCharSet("utf8mb3")
                            .UseCollation("utf8mb3_general_ci");
                        j.HasIndex(new[] { "Orderid" }, "fk_user_order_orderid");
                        j.HasIndex(new[] { "Userid" }, "fk_user_order_userid");
                        j.IndexerProperty<int>("Userid").HasColumnName("userid");
                        j.IndexerProperty<int>("Orderid").HasColumnName("orderid");
                    });

            entity.HasMany(d => d.Reports).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "TcUserReport",
                    r => r.HasOne<TcReport>().WithMany()
                        .HasForeignKey("Reportid")
                        .HasConstraintName("fk_user_report_reportid"),
                    l => l.HasOne<TcUser>().WithMany()
                        .HasForeignKey("Userid")
                        .HasConstraintName("fk_user_report_userid"),
                    j =>
                    {
                        j.HasKey("Userid", "Reportid")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j
                            .ToTable("tc_user_report")
                            .HasCharSet("utf8mb3")
                            .UseCollation("utf8mb3_general_ci");
                        j.HasIndex(new[] { "Reportid" }, "fk_user_report_reportid");
                        j.HasIndex(new[] { "Userid" }, "fk_user_report_userid");
                        j.IndexerProperty<int>("Userid").HasColumnName("userid");
                        j.IndexerProperty<int>("Reportid").HasColumnName("reportid");
                    });

            entity.HasMany(d => d.Users).WithMany(p => p.Managedusers)
                .UsingEntity<Dictionary<string, object>>(
                    "TcUserUser",
                    r => r.HasOne<TcUser>().WithMany()
                        .HasForeignKey("Userid")
                        .HasConstraintName("fk_user_user_userid"),
                    l => l.HasOne<TcUser>().WithMany()
                        .HasForeignKey("Manageduserid")
                        .HasConstraintName("fk_user_user_manageduserid"),
                    j =>
                    {
                        j.HasKey("Userid", "Manageduserid")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j
                            .ToTable("tc_user_user")
                            .HasCharSet("utf8mb3")
                            .UseCollation("utf8mb3_general_ci");
                        j.HasIndex(new[] { "Manageduserid" }, "fk_user_user_manageduserid");
                        j.HasIndex(new[] { "Userid" }, "fk_user_user_userid");
                        j.IndexerProperty<int>("Userid").HasColumnName("userid");
                        j.IndexerProperty<int>("Manageduserid").HasColumnName("manageduserid");
                    });
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
