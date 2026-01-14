using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh;

public partial class JadehDbContext : DbContext
{
    public JadehDbContext()
    {
    }

    public JadehDbContext(DbContextOptions<JadehDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AggregatedCounter> AggregatedCounters { get; set; }
    public virtual DbSet<LatestTagEvent> LatestTagEvents { get; set; }


    public virtual DbSet<VehicleAvlDataPatchRecovery> VehicleAvlDataPatchRecovery { get; set; }
    public virtual DbSet<AggregatedCounter1> AggregatedCounters1 { get; set; }

    public virtual DbSet<Alarm> Alarms { get; set; }

    public virtual DbSet<AlarmsStatusType> AlarmsStatusTypes { get; set; }

    public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; }

    public virtual DbSet<ApplicationUserContractType> ApplicationUserContractTypes { get; set; }

    public virtual DbSet<ApplicationUserLocalization> ApplicationUserLocalizations { get; set; }

    public virtual DbSet<ApplicationUserType> ApplicationUserTypes { get; set; }

    public virtual DbSet<Bin> Bins { get; set; }

    public virtual DbSet<BinGroup> BinGroups { get; set; }

    public virtual DbSet<BinGroupMember> BinGroupMembers { get; set; }

    public virtual DbSet<BinType> BinTypes { get; set; }

    public virtual DbSet<Contract> Contracts { get; set; }

    public virtual DbSet<ContractAudiTrail> ContractAudiTrails { get; set; }

    public virtual DbSet<ContractDetail> ContractDetails { get; set; }

    public virtual DbSet<ContractDetailsFile> ContractDetailsFiles { get; set; }

    public virtual DbSet<ContractFile> ContractFiles { get; set; }

    public virtual DbSet<ContractGroup> ContractGroups { get; set; }

    public virtual DbSet<ContractLocalization> ContractLocalizations { get; set; }

    public virtual DbSet<ContractMapGeometry> ContractMapGeometries { get; set; }

    public virtual DbSet<ContractService> ContractServices { get; set; }

    public virtual DbSet<ContractServiceMapGeometry> ContractServiceMapGeometries { get; set; }

    public virtual DbSet<ContractType> ContractTypes { get; set; }

    public virtual DbSet<ContractTypeManager> ContractTypeManagers { get; set; }

    public virtual DbSet<ContractTypeTransporter> ContractTypeTransporters { get; set; }

    public virtual DbSet<ContractUiConfiguration> ContractUiConfigurations { get; set; }

    public virtual DbSet<ContractingCompany> ContractingCompanies { get; set; }

    public virtual DbSet<ContractingCompanyLocalization> ContractingCompanyLocalizations { get; set; }

    public virtual DbSet<ContractingDevice> ContractingDevices { get; set; }

    public virtual DbSet<Counter> Counters { get; set; }

    public virtual DbSet<Counter1> Counters1 { get; set; }

    public virtual DbSet<Crew> Crews { get; set; }

    public virtual DbSet<CrewLocalization> CrewLocalizations { get; set; }

    public virtual DbSet<CrewOperationalPlan> CrewOperationalPlans { get; set; }

    public virtual DbSet<CrewType> CrewTypes { get; set; }

    public virtual DbSet<Dictionary> Dictionaries { get; set; }

    public virtual DbSet<DictionaryLocaization> DictionaryLocaizations { get; set; }

    public virtual DbSet<DisposalPoint> DisposalPoints { get; set; }

    public virtual DbSet<DisposalPointLocalization> DisposalPointLocalizations { get; set; }

    public virtual DbSet<DriverOperationalPlan> DriverOperationalPlans { get; set; }

    public virtual DbSet<DriverTrip> DriverTrips { get; set; }

    public virtual DbSet<DynamicServiceProcessLog> DynamicServiceProcessLogs { get; set; }

    public virtual DbSet<ErrorsLocalization> ErrorsLocalizations { get; set; }

    public virtual DbSet<GeometryType> GeometryTypes { get; set; }

    public virtual DbSet<Hash> Hashes { get; set; }

    public virtual DbSet<Hash1> Hashes1 { get; set; }

    public virtual DbSet<Job> Jobs { get; set; }

    public virtual DbSet<Job1> Jobs1 { get; set; }

    public virtual DbSet<JobParameter> JobParameters { get; set; }

    public virtual DbSet<JobParameter1> JobParameters1 { get; set; }

    public virtual DbSet<JobQueue> JobQueues { get; set; }

    public virtual DbSet<JobQueue1> JobQueues1 { get; set; }

    public virtual DbSet<LicenseType> LicenseTypes { get; set; }

    public virtual DbSet<LicenseTypeLocalization> LicenseTypeLocalizations { get; set; }

    public virtual DbSet<List> Lists { get; set; }

    public virtual DbSet<List1> Lists1 { get; set; }

    public virtual DbSet<LocalizationVersion> LocalizationVersions { get; set; }

    public virtual DbSet<Lookup> Lookups { get; set; }

    public virtual DbSet<LookupCategory> LookupCategories { get; set; }

    public virtual DbSet<Nationality> Nationalities { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<NotificationType> NotificationTypes { get; set; }

    public virtual DbSet<NotificationTypeEntry> NotificationTypeEntries { get; set; }

    public virtual DbSet<OperationPlanLocalization> OperationPlanLocalizations { get; set; }

    public virtual DbSet<OperationPlanMonthlyFrequencyDay> OperationPlanMonthlyFrequencyDays { get; set; }

    public virtual DbSet<OperationalPlan> OperationalPlans { get; set; }

    public virtual DbSet<OperationalPlanDetail> OperationalPlanDetails { get; set; }

    public virtual DbSet<OperationalPlansDay> OperationalPlansDays { get; set; }

    public virtual DbSet<OvernightPoint> OvernightPoints { get; set; }

    public virtual DbSet<OvernightPointLocalization> OvernightPointLocalizations { get; set; }

    public virtual DbSet<Privilege> Privileges { get; set; }

    public virtual DbSet<PrivilegeGroup> PrivilegeGroups { get; set; }

    public virtual DbSet<ReportAggregate> ReportAggregates { get; set; }

    public virtual DbSet<ReportColumn> ReportColumns { get; set; }

    public virtual DbSet<ReportEngine> ReportEngines { get; set; }

    public virtual DbSet<ReportFilter> ReportFilters { get; set; }

    public virtual DbSet<ReportGroup> ReportGroups { get; set; }

    public virtual DbSet<ReportRunHistory> ReportRunHistories { get; set; }

    public virtual DbSet<ReportSchedule> ReportSchedules { get; set; }

    public virtual DbSet<ReportSort> ReportSorts { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<RoleLocalization> RoleLocalizations { get; set; }

    public virtual DbSet<RolePrivilege> RolePrivileges { get; set; }

    public virtual DbSet<Schema> Schemas { get; set; }

    public virtual DbSet<Schema1> Schemas1 { get; set; }

    public virtual DbSet<SeedingHistory> SeedingHistories { get; set; }

    public virtual DbSet<Server> Servers { get; set; }

    public virtual DbSet<Server1> Servers1 { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    public virtual DbSet<ServiceCrewType> ServiceCrewTypes { get; set; }

    public virtual DbSet<ServiceGeometryType> ServiceGeometryTypes { get; set; }

    public virtual DbSet<ServiceGroup> ServiceGroups { get; set; }

    public virtual DbSet<ServiceGroupContractType> ServiceGroupContractTypes { get; set; }

    public virtual DbSet<ServiceGroupLocalization> ServiceGroupLocalizations { get; set; }

    public virtual DbSet<ServiceGroupServiceGroupType> ServiceGroupServiceGroupTypes { get; set; }

    public virtual DbSet<ServiceGroupType> ServiceGroupTypes { get; set; }

    public virtual DbSet<ServiceLocalization> ServiceLocalizations { get; set; }

    public virtual DbSet<ServiceUiConfiguration> ServiceUiConfigurations { get; set; }

    public virtual DbSet<ServiceVehicleType> ServiceVehicleTypes { get; set; }

    public virtual DbSet<Set> Sets { get; set; }

    public virtual DbSet<Set1> Sets1 { get; set; }

    public virtual DbSet<State> States { get; set; }

    public virtual DbSet<State1> States1 { get; set; }

    public virtual DbSet<SupportedLanguage> SupportedLanguages { get; set; }

    public virtual DbSet<SupportedLanguagesNew> SupportedLanguagesNews { get; set; }

    public virtual DbSet<Trip> Trips { get; set; }

    public virtual DbSet<TripDetail> TripDetails { get; set; }

    public virtual DbSet<TripDetailsFile> TripDetailsFiles { get; set; }

    public virtual DbSet<TripDetailsProcessingSummary> TripDetailsProcessingSummaries { get; set; }

    public virtual DbSet<TripFile> TripFiles { get; set; }

    public virtual DbSet<TripLocalizationLocalization> TripLocalizationLocalizations { get; set; }

    public virtual DbSet<TripProcessingSummary> TripProcessingSummaries { get; set; }

    public virtual DbSet<Vehicle> Vehicles { get; set; }

    public virtual DbSet<VehicleAvlDataPatch> VehicleAvlDataPatches { get; set; }

    public virtual DbSet<VehicleLatestPoint> VehicleLatestPoints { get; set; }

    public virtual DbSet<VehicleOperationalPlan> VehicleOperationalPlans { get; set; }

    public virtual DbSet<VehicleTrip> VehicleTrips { get; set; }

    public virtual DbSet<VehicleType> VehicleTypes { get; set; }

    public virtual DbSet<VehiclesAvlDataPartitioned> VehiclesAvlDataPartitioneds { get; set; }

    public virtual DbSet<VehiclesAvlDatum> VehiclesAvlData { get; set; }

    public virtual DbSet<VwMapGeometry> VwMapGeometries { get; set; }

    public virtual DbSet<WeekDay> WeekDays { get; set; }

    public virtual DbSet<WeekDaysLocalization> WeekDaysLocalizations { get; set; }

    public virtual DbSet<Zone> Zones { get; set; }

    public virtual DbSet<ZoneType> ZoneTypes { get; set; }

    public virtual DbSet<ZoneTypeLocalization> ZoneTypeLocalizations { get; set; }

    public virtual DbSet<ZonesLocalization> ZonesLocalizations { get; set; }

    public virtual DbSet<ZonesVehicle> ZonesVehicles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=145.241.157.1;Database=AVL22_Prod;TrustServerCertificate=True;User ID=khaled;Password=Khaled@2024!;Connect Timeout=60;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AggregatedCounter>(entity =>
        {
            entity.HasKey(e => e.Key).HasName("PK_HangFire_CounterAggregated");

            entity.HasIndex(e => e.ExpireAt, "IX_HangFire_AggregatedCounter_ExpireAt").HasFilter("([ExpireAt] IS NOT NULL)");
        });

        modelBuilder.Entity<AggregatedCounter1>(entity =>
        {
            entity.HasKey(e => e.Key).HasName("PK_HangFire_CounterAggregated");

            entity.HasIndex(e => e.ExpireAt, "IX_HangFire_AggregatedCounter_ExpireAt").HasFilter("([ExpireAt] IS NOT NULL)");
        });

        modelBuilder.Entity<Alarm>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<AlarmsStatusType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<ApplicationUser>(entity =>
        {
            entity.HasIndex(e => e.CrewId, "IX_ApplicationUsers_CrewId")
                .IsUnique()
                .HasFilter("([CrewId] IS NOT NULL)");

            entity.HasIndex(e => e.NationalId, "IX_ApplicationUsers_NationalId")
                .IsUnique()
                .HasFilter("([NationalId] IS NOT NULL)");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.IsActive).HasDefaultValue(true);

            entity.HasOne(d => d.Crew).WithOne(p => p.ApplicationUser).OnDelete(DeleteBehavior.SetNull);

            entity.HasOne(d => d.Role).WithMany(p => p.ApplicationUsers).OnDelete(DeleteBehavior.SetNull);
        });

        modelBuilder.Entity<ApplicationUserContractType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.ApplicationUser).WithMany(p => p.ApplicationUserContractTypes).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<ApplicationUserLocalization>(entity =>
        {
            entity.Property(e => e.CreatedBy).HasDefaultValue("");
        });

        modelBuilder.Entity<ApplicationUserType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Bin>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.ContractType).WithMany(p => p.Bins).OnDelete(DeleteBehavior.SetNull);
        });

        modelBuilder.Entity<BinGroup>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<BinGroupMember>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<BinType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.DictionaryId).HasDefaultValue(1);
        });

        modelBuilder.Entity<Contract>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<ContractAudiTrail>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.AuditTrailApplicationUser).WithMany(p => p.ContractAudiTrails).OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<ContractDetail>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<ContractDetailsFile>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<ContractFile>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<ContractLocalization>(entity =>
        {
            entity.Property(e => e.CreatedBy).HasDefaultValue("");
        });

        modelBuilder.Entity<ContractMapGeometry>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<ContractService>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Service).WithMany(p => p.ContractServices).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<ContractServiceMapGeometry>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasDefaultValue("");

            entity.HasOne(d => d.Bin).WithMany(p => p.ContractServiceMapGeometries).OnDelete(DeleteBehavior.SetNull);
        });

        modelBuilder.Entity<ContractType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Dictionary).WithMany(p => p.ContractTypes).HasConstraintName("FK_ContractTypes_Dictionary");
        });

        modelBuilder.Entity<ContractTypeManager>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<ContractTypeTransporter>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<ContractUiConfiguration>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasDefaultValue("");
            entity.Property(e => e.IsAllowedToUpdate).HasDefaultValue(true);

            entity.HasOne(d => d.ServiceGroup).WithOne(p => p.ContractUiConfiguration).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<ContractingCompany>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<ContractingCompanyLocalization>(entity =>
        {
            entity.Property(e => e.CreatedBy).HasDefaultValue("");
        });

        modelBuilder.Entity<ContractingDevice>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Counter>(entity =>
        {
            entity.HasKey(e => new { e.Key, e.Id }).HasName("PK_HangFire_Counter");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Counter1>(entity =>
        {
            entity.HasKey(e => new { e.Key, e.Id }).HasName("PK_HangFire_Counter");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Crew>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<CrewLocalization>(entity =>
        {
            entity.Property(e => e.CreatedBy).HasDefaultValue("");
        });

        modelBuilder.Entity<CrewOperationalPlan>(entity =>
        {
            entity.Property(e => e.CreatedBy).HasDefaultValue("");
        });

        modelBuilder.Entity<CrewType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Dictionary>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<DisposalPoint>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.ContractType).WithMany(p => p.DisposalPoints).OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(d => d.ContractingCompany).WithMany(p => p.DisposalPoints).OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<DisposalPointLocalization>(entity =>
        {
            entity.Property(e => e.CreatedBy).HasDefaultValue("");
        });

        modelBuilder.Entity<DriverOperationalPlan>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<DriverTrip>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<DynamicServiceProcessLog>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<ErrorsLocalization>(entity =>
        {
            entity.Property(e => e.Key).HasDefaultValue("");
            entity.Property(e => e.Locale).HasDefaultValue("");
            entity.Property(e => e.Text).HasDefaultValue("");
        });

        modelBuilder.Entity<Hash>(entity =>
        {
            entity.HasKey(e => new { e.Key, e.Field }).HasName("PK_HangFire_Hash");

            entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Hash_ExpireAt").HasFilter("([ExpireAt] IS NOT NULL)");
        });

        modelBuilder.Entity<Hash1>(entity =>
        {
            entity.HasKey(e => new { e.Key, e.Field }).HasName("PK_HangFire_Hash");

            entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Hash_ExpireAt").HasFilter("([ExpireAt] IS NOT NULL)");
        });

        modelBuilder.Entity<Job>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_HangFire_Job");

            entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Job_ExpireAt").HasFilter("([ExpireAt] IS NOT NULL)");

            entity.HasIndex(e => e.StateName, "IX_HangFire_Job_StateName").HasFilter("([StateName] IS NOT NULL)");
        });

        modelBuilder.Entity<Job1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_HangFire_Job");

            entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Job_ExpireAt").HasFilter("([ExpireAt] IS NOT NULL)");

            entity.HasIndex(e => e.StateName, "IX_HangFire_Job_StateName").HasFilter("([StateName] IS NOT NULL)");
        });

        modelBuilder.Entity<JobParameter>(entity =>
        {
            entity.HasKey(e => new { e.JobId, e.Name }).HasName("PK_HangFire_JobParameter");

            entity.HasOne(d => d.Job).WithMany(p => p.JobParameters).HasConstraintName("FK_HangFire_JobParameter_Job");
        });

        modelBuilder.Entity<JobParameter1>(entity =>
        {
            entity.HasKey(e => new { e.JobId, e.Name }).HasName("PK_HangFire_JobParameter");

            entity.HasOne(d => d.Job).WithMany(p => p.JobParameter1s).HasConstraintName("FK_HangFire_JobParameter_Job");
        });

        modelBuilder.Entity<JobQueue>(entity =>
        {
            entity.HasKey(e => new { e.Queue, e.Id }).HasName("PK_HangFire_JobQueue");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<JobQueue1>(entity =>
        {
            entity.HasKey(e => new { e.Queue, e.Id }).HasName("PK_HangFire_JobQueue");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LicenseType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<LicenseTypeLocalization>(entity =>
        {
            entity.Property(e => e.CreatedBy).HasDefaultValue("");
        });

        modelBuilder.Entity<List>(entity =>
        {
            entity.HasKey(e => new { e.Key, e.Id }).HasName("PK_HangFire_List");

            entity.HasIndex(e => e.ExpireAt, "IX_HangFire_List_ExpireAt").HasFilter("([ExpireAt] IS NOT NULL)");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<List1>(entity =>
        {
            entity.HasKey(e => new { e.Key, e.Id }).HasName("PK_HangFire_List");

            entity.HasIndex(e => e.ExpireAt, "IX_HangFire_List_ExpireAt").HasFilter("([ExpireAt] IS NOT NULL)");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LookupCategory>(entity =>
        {
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<Nationality>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<NotificationType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.MessageDictionary).WithMany(p => p.NotificationTypeMessageDictionaries).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.TitleDictionary).WithMany(p => p.NotificationTypeTitleDictionaries).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<OperationPlanLocalization>(entity =>
        {
            entity.Property(e => e.CreatedBy).HasDefaultValue("");
        });

        modelBuilder.Entity<OperationPlanMonthlyFrequencyDay>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<OperationalPlan>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ContractServiceId).HasDefaultValue(new Guid("00000000-0000-0000-0000-000000000000"));
            entity.Property(e => e.Status).HasDefaultValue(9);

            entity.HasOne(d => d.Contract).WithMany(p => p.OperationalPlans).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<OperationalPlanDetail>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.ContractServiceMapGeometry).WithMany(p => p.OperationalPlanDetails).OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(d => d.OperationalPlan).WithMany(p => p.OperationalPlanDetails).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<OperationalPlansDay>(entity =>
        {
            entity.HasOne(d => d.WeekDays).WithMany(p => p.OperationalPlansDays).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<OvernightPoint>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.ContractType).WithMany(p => p.OvernightPoints).OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<OvernightPointLocalization>(entity =>
        {
            entity.Property(e => e.CreatedBy).HasDefaultValue("");
        });

        modelBuilder.Entity<Privilege>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Dictionary).WithMany(p => p.Privileges).HasConstraintName("FK_Privileges_Dictionary");

            entity.HasOne(d => d.PrivilegeGroup).WithMany(p => p.Privileges).OnDelete(DeleteBehavior.SetNull);
        });

        modelBuilder.Entity<PrivilegeGroup>(entity =>
        {
            entity.HasOne(d => d.Dictionary).WithMany(p => p.PrivilegeGroups).HasConstraintName("FK_PrivilegeGroups_Dictionary");
        });

        modelBuilder.Entity<ReportAggregate>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<ReportColumn>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<ReportEngine>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<ReportFilter>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<ReportGroup>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<ReportRunHistory>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<ReportSchedule>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<ReportSort>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<RoleLocalization>(entity =>
        {
            entity.Property(e => e.CreatedBy).HasDefaultValue("");
        });

        modelBuilder.Entity<RolePrivilege>(entity =>
        {
            entity.HasOne(d => d.Privilege).WithMany(p => p.RolePrivileges).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Schema>(entity =>
        {
            entity.HasKey(e => e.Version).HasName("PK_HangFire_Schema");

            entity.Property(e => e.Version).ValueGeneratedNever();
        });

        modelBuilder.Entity<Schema1>(entity =>
        {
            entity.HasKey(e => e.Version).HasName("PK_HangFire_Schema");

            entity.Property(e => e.Version).ValueGeneratedNever();
        });

        modelBuilder.Entity<Server>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_HangFire_Server");
        });

        modelBuilder.Entity<Server1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_HangFire_Server");
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<ServiceGroup>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<ServiceGroupLocalization>(entity =>
        {
            entity.Property(e => e.CreatedBy).HasDefaultValue("");
        });

        modelBuilder.Entity<ServiceGroupType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<ServiceLocalization>(entity =>
        {
            entity.Property(e => e.CreatedBy).HasDefaultValue("");
        });

        modelBuilder.Entity<ServiceUiConfiguration>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.IsOptional).HasDefaultValue(true);

            entity.HasOne(d => d.Service).WithOne(p => p.ServiceUiConfiguration).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Set>(entity =>
        {
            entity.HasKey(e => new { e.Key, e.Value }).HasName("PK_HangFire_Set");

            entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Set_ExpireAt").HasFilter("([ExpireAt] IS NOT NULL)");
        });

        modelBuilder.Entity<Set1>(entity =>
        {
            entity.HasKey(e => new { e.Key, e.Value }).HasName("PK_HangFire_Set");

            entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Set_ExpireAt").HasFilter("([ExpireAt] IS NOT NULL)");
        });

        modelBuilder.Entity<State>(entity =>
        {
            entity.HasKey(e => new { e.JobId, e.Id }).HasName("PK_HangFire_State");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Job).WithMany(p => p.States).HasConstraintName("FK_HangFire_State_Job");
        });

        modelBuilder.Entity<State1>(entity =>
        {
            entity.HasKey(e => new { e.JobId, e.Id }).HasName("PK_HangFire_State");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Job).WithMany(p => p.State1s).HasConstraintName("FK_HangFire_State_Job");
        });

        modelBuilder.Entity<SupportedLanguage>(entity =>
        {
            entity.Property(e => e.Active).HasDefaultValue(true);
        });

        modelBuilder.Entity<Trip>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.OperationalPlans).WithMany(p => p.Trips).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<TripDetail>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.TagHash).HasComputedColumnSql("(CONVERT([varbinary](32),hashbytes('SHA2_256',CONVERT([nvarchar](4000),[TagId]))))", true);

            entity.HasOne(d => d.ContractServiceMapGeometry).WithMany(p => p.TripDetails).OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<TripDetailsFile>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<TripDetailsProcessingSummary>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasDefaultValue("");
        });

        modelBuilder.Entity<TripFile>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<TripLocalizationLocalization>(entity =>
        {
            entity.Property(e => e.CreatedBy).HasDefaultValue("");
            entity.Property(e => e.CreatedByChecksum).HasComputedColumnSql("(checksum([CreatedBy]))", true);
        });

        modelBuilder.Entity<TripProcessingSummary>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Vehicle>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<VehicleAvlDataPatch>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<VehicleLatestPoint>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.RowVersion)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.Vehicle).WithOne(p => p.VehicleLatestPoint).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<VehicleOperationalPlan>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Vehicle).WithMany(p => p.VehicleOperationalPlans).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<VehicleTrip>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<VehicleType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<VehiclesAvlDatum>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Vehicle).WithMany(p => p.VehiclesAvlData).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<VwMapGeometry>(entity =>
        {
            entity.ToView("vwMapGeometry");
        });

        modelBuilder.Entity<WeekDay>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<WeekDaysLocalization>(entity =>
        {
            entity.Property(e => e.CreatedBy).HasDefaultValue("");
        });

        modelBuilder.Entity<Zone>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<ZoneType>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<ZoneTypeLocalization>(entity =>
        {
            entity.Property(e => e.CreatedBy).HasDefaultValue("");
        });

        modelBuilder.Entity<ZonesLocalization>(entity =>
        {
            entity.Property(e => e.CreatedBy).HasDefaultValue("");
        });
        modelBuilder.Entity<LatestTagEvent>(entity =>
        {
            entity.ToTable("LatestTagEvent");

            entity.HasIndex(e => e.IsDeleted, "IX_LatestTagEvent_IsDeleted");

            entity.HasIndex(e => e.TenantId, "IX_LatestTagEvent_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Createdby).HasMaxLength(200);
            entity.Property(e => e.Tag).HasMaxLength(200);
            entity.Property(e => e.TrackingDeviceNumber).HasMaxLength(200);
        });
        modelBuilder.Entity<VehicleAvlDataPatchRecovery>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VehicleA__3214EC072E7819AD");

            entity.ToTable("VehicleAvlDataPatchRecovery");

            entity.HasIndex(e => e.IsDeleted, "IX_VehicleAvlDataPatchRecovery_IsDeleted");

            entity.HasIndex(e => e.MovementTime, "IX_VehicleAvlDataPatchRecovery_MovementTime");

            entity.HasIndex(e => e.TenantId, "IX_VehicleAvlDataPatchRecovery_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AnalogInput1).HasMaxLength(200);
            entity.Property(e => e.Createdby).HasMaxLength(200);
            entity.Property(e => e.DigitalInput1).HasMaxLength(200);
            entity.Property(e => e.Imei)
                .HasMaxLength(200)
                .HasColumnName("IMEI");
            entity.Property(e => e.LastTag).HasMaxLength(200);
            entity.Property(e => e.PlateNumber).HasMaxLength(200);
            entity.Property(e => e.Tag).HasMaxLength(200);
        });
 
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
