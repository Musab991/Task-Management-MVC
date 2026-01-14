using Microsoft.EntityFrameworkCore;
using VehicleAvlTrackingConsumer.Models.QA;

namespace VehicleAvlTrackingConsumer.Models;

public partial class JadehQaDbContext : DbContext
{
    public JadehQaDbContext()
    {
    }

    public JadehQaDbContext(DbContextOptions<JadehQaDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AggregatedCounter> AggregatedCounters { get; set; }

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

    public virtual DbSet<DisposalPointCategory> DisposalPointCategories { get; set; }

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

    public virtual DbSet<LatestTagEvent> LatestTagEvents { get; set; }

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

    public virtual DbSet<QA.Service> Services { get; set; }

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

    public virtual DbSet<SpInsertDebugLog> SpInsertDebugLogs { get; set; }

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

    public virtual DbSet<VehicleAvlDataPatchRecovery> VehicleAvlDataPatchRecoveries { get; set; }

    public virtual DbSet<VehicleAvlDataPatchRecoveryV2> VehicleAvlDataPatchRecoveryV2s { get; set; }

    public virtual DbSet<VehicleLatestPoint> VehicleLatestPoints { get; set; }

    public virtual DbSet<VehicleOperationalPlan> VehicleOperationalPlans { get; set; }

    public virtual DbSet<VehicleTrip> VehicleTrips { get; set; }

    public virtual DbSet<VehicleType> VehicleTypes { get; set; }

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
        => optionsBuilder.UseSqlServer("Name=JadehQa22");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AggregatedCounter>(entity =>
        {
            entity.HasKey(e => e.Key).HasName("PK_HangFire_CounterAggregated");

            entity.ToTable("AggregatedCounter", "Hangfire");

            entity.HasIndex(e => e.ExpireAt, "IX_HangFire_AggregatedCounter_ExpireAt").HasFilter("([ExpireAt] IS NOT NULL)");

            entity.Property(e => e.Key).HasMaxLength(100);
            entity.Property(e => e.ExpireAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<AggregatedCounter1>(entity =>
        {
            entity.HasKey(e => e.Key).HasName("PK_HangFire_CounterAggregated");

            entity.ToTable("AggregatedCounter", "HangfireDev");

            entity.HasIndex(e => e.ExpireAt, "IX_HangFire_AggregatedCounter_ExpireAt").HasFilter("([ExpireAt] IS NOT NULL)");

            entity.Property(e => e.Key).HasMaxLength(100);
            entity.Property(e => e.ExpireAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<Alarm>(entity =>
        {
            entity.HasIndex(e => e.AlarmsStatusTypeId, "IX_Alarms_AlarmsStatusTypeId");

            entity.HasIndex(e => e.CreatedDate, "IX_Alarms_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_Alarms_IsDeleted");

            entity.HasIndex(e => e.TenantId, "IX_Alarms_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.AlarmsStatusType).WithMany(p => p.Alarms).HasForeignKey(d => d.AlarmsStatusTypeId);
        });

        modelBuilder.Entity<AlarmsStatusType>(entity =>
        {
            entity.HasIndex(e => e.DictionaryId, "IX_AlarmsStatusTypes_DictionaryId");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Dictionary).WithMany(p => p.AlarmsStatusTypes).HasForeignKey(d => d.DictionaryId);
        });

        modelBuilder.Entity<ApplicationUser>(entity =>
        {
            entity.HasIndex(e => e.ContractingCompanyId, "IX_ApplicationUsers_ContractingCompanyId");

            entity.HasIndex(e => e.CreatedDate, "IX_ApplicationUsers_CreatedDate");

            entity.HasIndex(e => e.CrewId, "IX_ApplicationUsers_CrewId")
                .IsUnique()
                .HasFilter("([CrewId] IS NOT NULL)");

            entity.HasIndex(e => e.IsDeleted, "IX_ApplicationUsers_IsDeleted");

            entity.HasIndex(e => e.NationalId, "IX_ApplicationUsers_NationalId")
                .IsUnique()
                .HasFilter("([NationalId] IS NOT NULL)");

            entity.HasIndex(e => e.PhoneNumber, "IX_ApplicationUsers_PhoneNumber");

            entity.HasIndex(e => e.RoleId, "IX_ApplicationUsers_RoleId");

            entity.HasIndex(e => e.TenantId, "IX_ApplicationUsers_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Locale)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.NationalId).HasMaxLength(200);
            entity.Property(e => e.Password).HasMaxLength(255);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.RefreshToken).HasMaxLength(200);
            entity.Property(e => e.SurName).HasMaxLength(100);

            entity.HasOne(d => d.ContractingCompany).WithMany(p => p.ApplicationUsers).HasForeignKey(d => d.ContractingCompanyId);

            entity.HasOne(d => d.Crew).WithOne(p => p.ApplicationUser)
                .HasForeignKey<ApplicationUser>(d => d.CrewId)
                .OnDelete(DeleteBehavior.SetNull);

            entity.HasOne(d => d.Role).WithMany(p => p.ApplicationUsers)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.SetNull);
        });

        modelBuilder.Entity<ApplicationUserContractType>(entity =>
        {
            entity.ToTable("ApplicationUserContractType");

            entity.HasIndex(e => e.ApplicationUserId, "IX_ApplicationUserContractType_ApplicationUserId");

            entity.HasIndex(e => e.ContractTypeId, "IX_ApplicationUserContractType_ContractTypeId");

            entity.HasIndex(e => e.CreatedDate, "IX_ApplicationUserContractType_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_ApplicationUserContractType_IsDeleted");

            entity.HasIndex(e => e.TenantId, "IX_ApplicationUserContractType_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.ApplicationUser).WithMany(p => p.ApplicationUserContractTypes)
                .HasForeignKey(d => d.ApplicationUserId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.ContractType).WithMany(p => p.ApplicationUserContractTypes).HasForeignKey(d => d.ContractTypeId);
        });

        modelBuilder.Entity<ApplicationUserLocalization>(entity =>
        {
            entity.ToTable("ApplicationUser_Localizations");

            entity.HasIndex(e => e.CreatedDate, "IX_ApplicationUser_Localizations_CreatedDate");

            entity.HasIndex(e => e.EntityId, "IX_ApplicationUser_Localizations_EntityId");

            entity.HasIndex(e => e.IsDeleted, "IX_ApplicationUser_Localizations_IsDeleted");

            entity.HasIndex(e => e.LanguageLocale, "IX_ApplicationUser_Localizations_LanguageLocale");

            entity.HasIndex(e => e.TenantId, "IX_ApplicationUser_Localizations_TenantId");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasDefaultValue("");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.LanguageLocale)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.Entity).WithMany(p => p.ApplicationUserLocalizations).HasForeignKey(d => d.EntityId);

            entity.HasOne(d => d.LanguageLocaleNavigation).WithMany(p => p.ApplicationUserLocalizations).HasForeignKey(d => d.LanguageLocale);
        });

        modelBuilder.Entity<ApplicationUserType>(entity =>
        {
            entity.ToTable("ApplicationUserType");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<Bin>(entity =>
        {
            entity.HasIndex(e => e.BinTypeId, "IX_Bins_BinTypeId");

            entity.HasIndex(e => e.ContractTypeId, "IX_Bins_ContractTypeId");

            entity.HasIndex(e => e.ContractingCompanyId, "IX_Bins_ContractingCompanyId");

            entity.HasIndex(e => e.CreatedDate, "IX_Bins_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_Bins_IsDeleted");

            entity.HasIndex(e => e.TagId, "IX_Bins_TagId");

            entity.HasIndex(e => e.TenantId, "IX_Bins_TenantId");

            entity.HasIndex(e => e.TypeLookupId, "IX_Bins_TypeLookupId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);
            entity.Property(e => e.Number).HasMaxLength(200);
            entity.Property(e => e.TagId).HasMaxLength(200);

            entity.HasOne(d => d.BinType).WithMany(p => p.Bins).HasForeignKey(d => d.BinTypeId);

            entity.HasOne(d => d.ContractType).WithMany(p => p.Bins)
                .HasForeignKey(d => d.ContractTypeId)
                .OnDelete(DeleteBehavior.SetNull);

            entity.HasOne(d => d.ContractingCompany).WithMany(p => p.Bins).HasForeignKey(d => d.ContractingCompanyId);

            entity.HasOne(d => d.TypeLookup).WithMany(p => p.Bins).HasForeignKey(d => d.TypeLookupId);
        });

        modelBuilder.Entity<BinGroup>(entity =>
        {
            entity.ToTable("BinGroup");

            entity.HasIndex(e => e.CreatedDate, "IX_BinGroup_CreatedDate");

            entity.HasIndex(e => e.TenantId, "IX_BinGroup_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);
        });

        modelBuilder.Entity<BinGroupMember>(entity =>
        {
            entity.ToTable("BinGroupMember");

            entity.HasIndex(e => e.BinGroupId, "IX_BinGroupMember_BinGroupId");

            entity.HasIndex(e => e.BinId, "IX_BinGroupMember_BinId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.BinTag).HasMaxLength(200);

            entity.HasOne(d => d.BinGroup).WithMany(p => p.BinGroupMembers).HasForeignKey(d => d.BinGroupId);

            entity.HasOne(d => d.Bin).WithMany(p => p.BinGroupMembers).HasForeignKey(d => d.BinId);
        });

        modelBuilder.Entity<BinType>(entity =>
        {
            entity.ToTable("BinType");

            entity.HasIndex(e => e.CreatedDate, "IX_BinType_CreatedDate");

            entity.HasIndex(e => e.DictionaryId, "IX_BinType_DictionaryID");

            entity.HasIndex(e => e.IsDeleted, "IX_BinType_IsDeleted");

            entity.HasIndex(e => e.TenantId, "IX_BinType_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.DictionaryId)
                .HasDefaultValue(1)
                .HasColumnName("DictionaryID");
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(200);

            entity.HasOne(d => d.Dictionary).WithMany(p => p.BinTypes).HasForeignKey(d => d.DictionaryId);
        });

        modelBuilder.Entity<Contract>(entity =>
        {
            entity.HasIndex(e => e.ContractTypeId, "IX_Contracts_ContractTypeId");

            entity.HasIndex(e => e.ContractingCompanyId, "IX_Contracts_ContractingCompanyId");

            entity.HasIndex(e => e.CreatedDate, "IX_Contracts_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_Contracts_IsDeleted");

            entity.HasIndex(e => e.Number, "IX_Contracts_Number").IsUnique();

            entity.HasIndex(e => e.TenantId, "IX_Contracts_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);
            entity.Property(e => e.Number).HasMaxLength(50);

            entity.HasOne(d => d.ContractType).WithMany(p => p.Contracts).HasForeignKey(d => d.ContractTypeId);

            entity.HasOne(d => d.ContractingCompany).WithMany(p => p.Contracts).HasForeignKey(d => d.ContractingCompanyId);
        });

        modelBuilder.Entity<ContractAudiTrail>(entity =>
        {
            entity.ToTable("ContractAudiTrail");

            entity.HasIndex(e => e.AuditTrailApplicationUserId, "IX_ContractAudiTrail_AuditTrailApplicationUserId");

            entity.HasIndex(e => e.ContractId, "IX_ContractAudiTrail_ContractId");

            entity.HasIndex(e => e.CreatedDate, "IX_ContractAudiTrail_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_ContractAudiTrail_IsDeleted");

            entity.HasIndex(e => e.TenantId, "IX_ContractAudiTrail_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);
            entity.Property(e => e.NewStatusId).HasColumnName("NewStatusID");
            entity.Property(e => e.Note).HasMaxLength(200);
            entity.Property(e => e.OldStatusId).HasColumnName("OldStatusID");

            entity.HasOne(d => d.AuditTrailApplicationUser).WithMany(p => p.ContractAudiTrails)
                .HasForeignKey(d => d.AuditTrailApplicationUserId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<ContractDetail>(entity =>
        {
            entity.HasIndex(e => e.ContractServiceId, "IX_ContractDetails_ContractServiceId").IsUnique();

            entity.HasIndex(e => e.CreatedDate, "IX_ContractDetails_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_ContractDetails_IsDeleted");

            entity.HasIndex(e => e.TenantId, "IX_ContractDetails_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.ContractService).WithOne(p => p.ContractDetail).HasForeignKey<ContractDetail>(d => d.ContractServiceId);
        });

        modelBuilder.Entity<ContractDetailsFile>(entity =>
        {
            entity.HasIndex(e => e.ContractServiceId, "IX_ContractDetailsFiles_ContractServiceId");

            entity.HasIndex(e => e.CreatedDate, "IX_ContractDetailsFiles_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_ContractDetailsFiles_IsDeleted");

            entity.HasIndex(e => e.TenantId, "IX_ContractDetailsFiles_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.FileName).HasMaxLength(255);
            entity.Property(e => e.FilePath).HasMaxLength(500);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.ContractService).WithMany(p => p.ContractDetailsFiles).HasForeignKey(d => d.ContractServiceId);
        });

        modelBuilder.Entity<ContractFile>(entity =>
        {
            entity.HasIndex(e => e.ContractId, "IX_ContractFiles_ContractId");

            entity.HasIndex(e => e.CreatedDate, "IX_ContractFiles_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_ContractFiles_IsDeleted");

            entity.HasIndex(e => e.TenantId, "IX_ContractFiles_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.FileName).HasMaxLength(255);
            entity.Property(e => e.FilePath).HasMaxLength(500);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.Contract).WithMany(p => p.ContractFiles).HasForeignKey(d => d.ContractId);
        });

        modelBuilder.Entity<ContractGroup>(entity =>
        {
            entity.HasKey(e => new { e.ContractId, e.ServiceGroupId });

            entity.ToTable("ContractGroup");

            entity.HasIndex(e => e.CreatedDate, "IX_ContractGroup_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_ContractGroup_IsDeleted");

            entity.HasIndex(e => e.ServiceGroupId, "IX_ContractGroup_ServiceGroupId");

            entity.HasIndex(e => e.TenantId, "IX_ContractGroup_TenantId");

            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.Contract).WithMany(p => p.ContractGroups).HasForeignKey(d => d.ContractId);

            entity.HasOne(d => d.ServiceGroup).WithMany(p => p.ContractGroups).HasForeignKey(d => d.ServiceGroupId);
        });

        modelBuilder.Entity<ContractLocalization>(entity =>
        {
            entity.ToTable("Contract_Localizations");

            entity.HasIndex(e => e.CreatedDate, "IX_Contract_Localizations_CreatedDate");

            entity.HasIndex(e => e.EntityId, "IX_Contract_Localizations_EntityId");

            entity.HasIndex(e => e.IsDeleted, "IX_Contract_Localizations_IsDeleted");

            entity.HasIndex(e => e.LanguageLocale, "IX_Contract_Localizations_LanguageLocale");

            entity.HasIndex(e => e.TenantId, "IX_Contract_Localizations_TenantId");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasDefaultValue("");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.LanguageLocale)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.Entity).WithMany(p => p.ContractLocalizations).HasForeignKey(d => d.EntityId);

            entity.HasOne(d => d.LanguageLocaleNavigation).WithMany(p => p.ContractLocalizations).HasForeignKey(d => d.LanguageLocale);
        });

        modelBuilder.Entity<ContractMapGeometry>(entity =>
        {
            entity.ToTable("ContractMapGeometry");

            entity.HasIndex(e => e.ContractId, "IX_ContractMapGeometry_ContractId");

            entity.HasIndex(e => e.IsDeleted, "IX_ContractMapGeometry_IsDeleted");

            entity.HasIndex(e => e.TenantId, "IX_ContractMapGeometry_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Contract).WithMany(p => p.ContractMapGeometries).HasForeignKey(d => d.ContractId);
        });

        modelBuilder.Entity<ContractService>(entity =>
        {
            entity.HasIndex(e => e.ContractId, "IX_ContractServices_ContractId");

            entity.HasIndex(e => new { e.ContractId, e.ServiceGroupId }, "IX_ContractServices_ContractId_ServiceGroupId");

            entity.HasIndex(e => e.CreatedDate, "IX_ContractServices_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_ContractServices_IsDeleted");

            entity.HasIndex(e => e.ServiceGroupId, "IX_ContractServices_ServiceGroupId");

            entity.HasIndex(e => e.ServiceId, "IX_ContractServices_ServiceId");

            entity.HasIndex(e => e.TenantId, "IX_ContractServices_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.Contract).WithMany(p => p.ContractServices).HasForeignKey(d => d.ContractId);

            entity.HasOne(d => d.ServiceGroup).WithMany(p => p.ContractServices).HasForeignKey(d => d.ServiceGroupId);

            entity.HasOne(d => d.Service).WithMany(p => p.ContractServices)
                .HasForeignKey(d => d.ServiceId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<ContractServiceMapGeometry>(entity =>
        {
            entity.ToTable("ContractServiceMapGeometry");

            entity.HasIndex(e => new { e.ContractId, e.TenantId, e.IsDeleted }, "IX_CSMG_Contract_Tenant_IsDeleted");

            entity.HasIndex(e => e.BinId, "IX_ContractServiceMapGeometry_BinId");

            entity.HasIndex(e => e.ContractId, "IX_ContractServiceMapGeometry_ContractId");

            entity.HasIndex(e => e.ContractServiceId, "IX_ContractServiceMapGeometry_ContractServiceId");

            entity.HasIndex(e => e.CreatedDate, "IX_ContractServiceMapGeometry_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_ContractServiceMapGeometry_IsDeleted");

            entity.HasIndex(e => e.Tag, "IX_ContractServiceMapGeometry_Tag");

            entity.HasIndex(e => e.TenantId, "IX_ContractServiceMapGeometry_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasDefaultValue("");
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);
            entity.Property(e => e.ReferenceCode).HasMaxLength(200);
            entity.Property(e => e.Tag).HasMaxLength(200);

            entity.HasOne(d => d.Bin).WithMany(p => p.ContractServiceMapGeometries)
                .HasForeignKey(d => d.BinId)
                .OnDelete(DeleteBehavior.SetNull);

            entity.HasOne(d => d.Contract).WithMany(p => p.ContractServiceMapGeometries).HasForeignKey(d => d.ContractId);

            entity.HasOne(d => d.ContractService).WithMany(p => p.ContractServiceMapGeometries).HasForeignKey(d => d.ContractServiceId);
        });

        modelBuilder.Entity<ContractType>(entity =>
        {
            entity.HasIndex(e => e.CreatedDate, "IX_ContractTypes_CreatedDate");

            entity.HasIndex(e => e.DictionaryId, "IX_ContractTypes_DictionaryId");

            entity.HasIndex(e => e.IsDeleted, "IX_ContractTypes_IsDeleted");

            entity.HasIndex(e => e.TenantId, "IX_ContractTypes_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(100);

            entity.HasOne(d => d.Dictionary).WithMany(p => p.ContractTypes)
                .HasForeignKey(d => d.DictionaryId)
                .HasConstraintName("FK_ContractTypes_Dictionary");
        });

        modelBuilder.Entity<ContractTypeManager>(entity =>
        {
            entity.ToTable("ContractTypeManager");

            entity.HasIndex(e => e.ContractTypeId, "IX_ContractTypeManager_ContractTypeId");

            entity.HasIndex(e => e.CreatedDate, "IX_ContractTypeManager_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_ContractTypeManager_IsDeleted");

            entity.HasIndex(e => e.ManagerId, "IX_ContractTypeManager_ManagerId");

            entity.HasIndex(e => e.TenantId, "IX_ContractTypeManager_TenantId");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.ContractType).WithMany(p => p.ContractTypeManagers).HasForeignKey(d => d.ContractTypeId);

            entity.HasOne(d => d.Manager).WithMany(p => p.ContractTypeManagers).HasForeignKey(d => d.ManagerId);
        });

        modelBuilder.Entity<ContractTypeTransporter>(entity =>
        {
            entity.ToTable("ContractTypeTransporter");

            entity.HasIndex(e => e.ContractTypeId, "IX_ContractTypeTransporter_ContractTypeId");

            entity.HasIndex(e => e.CreatedDate, "IX_ContractTypeTransporter_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_ContractTypeTransporter_IsDeleted");

            entity.HasIndex(e => e.TenantId, "IX_ContractTypeTransporter_TenantId");

            entity.HasIndex(e => e.TransporterId, "IX_ContractTypeTransporter_TransporterId");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.ContractType).WithMany(p => p.ContractTypeTransporters).HasForeignKey(d => d.ContractTypeId);

            entity.HasOne(d => d.Transporter).WithMany(p => p.ContractTypeTransporters).HasForeignKey(d => d.TransporterId);
        });

        modelBuilder.Entity<ContractUiConfiguration>(entity =>
        {
            entity.HasIndex(e => e.CreatedDate, "IX_ContractUiConfigurations_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_ContractUiConfigurations_IsDeleted");

            entity.HasIndex(e => e.ServiceGroupId, "IX_ContractUiConfigurations_ServiceGroupId").IsUnique();

            entity.HasIndex(e => e.TenantId, "IX_ContractUiConfigurations_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasDefaultValue("");
            entity.Property(e => e.IsAllowedToUpdate).HasDefaultValue(true);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.ServiceGroup).WithOne(p => p.ContractUiConfiguration)
                .HasForeignKey<ContractUiConfiguration>(d => d.ServiceGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<ContractingCompany>(entity =>
        {
            entity.HasIndex(e => e.CreatedDate, "IX_ContractingCompanies_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_ContractingCompanies_IsDeleted");

            entity.HasIndex(e => e.TenantId, "IX_ContractingCompanies_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Address).HasMaxLength(200);
            entity.Property(e => e.CityAr)
                .HasMaxLength(200)
                .HasColumnName("CityAR");
            entity.Property(e => e.CityCode).HasMaxLength(200);
            entity.Property(e => e.CityEn)
                .HasMaxLength(200)
                .HasColumnName("CityEN");
            entity.Property(e => e.CommercialLicenseNumber).HasMaxLength(200);
            entity.Property(e => e.ContactNo).HasMaxLength(200);
            entity.Property(e => e.Crcapital).HasColumnName("CRCapital");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.ExpiryDate).HasMaxLength(200);
            entity.Property(e => e.FaxNo).HasMaxLength(200);
            entity.Property(e => e.IssueDate).HasMaxLength(200);
            entity.Property(e => e.LegalTypeAr)
                .HasMaxLength(200)
                .HasColumnName("LegalTypeAR");
            entity.Property(e => e.LegalTypeEn)
                .HasMaxLength(200)
                .HasColumnName("LegalTypeEN");
            entity.Property(e => e.LegalTypeId)
                .HasMaxLength(200)
                .HasColumnName("LegalTypeID");
            entity.Property(e => e.MainCrnumber)
                .HasMaxLength(200)
                .HasColumnName("MainCRNumber");
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);
            entity.Property(e => e.NationalNumber).HasMaxLength(200);
            entity.Property(e => e.Nationality).HasMaxLength(200);
            entity.Property(e => e.Number).HasMaxLength(200);
            entity.Property(e => e.PhoneNo).HasMaxLength(200);
            entity.Property(e => e.PhoneNumber).HasMaxLength(200);
            entity.Property(e => e.Pobox1)
                .HasMaxLength(200)
                .HasColumnName("POBOX1");
            entity.Property(e => e.Pobox2)
                .HasMaxLength(200)
                .HasColumnName("POBOX2");
            entity.Property(e => e.RecepDate).HasMaxLength(200);
            entity.Property(e => e.Status).HasMaxLength(200);
            entity.Property(e => e.StatusId).HasMaxLength(200);
            entity.Property(e => e.StatusReasonAr).HasMaxLength(200);
            entity.Property(e => e.StatusReasonEn)
                .HasMaxLength(200)
                .HasColumnName("StatusReasonEN");
            entity.Property(e => e.TransDate).HasMaxLength(200);
            entity.Property(e => e.Website).HasMaxLength(200);
            entity.Property(e => e.ZipCode).HasMaxLength(200);
        });

        modelBuilder.Entity<ContractingCompanyLocalization>(entity =>
        {
            entity.ToTable("ContractingCompany_Localizations");

            entity.HasIndex(e => e.CreatedDate, "IX_ContractingCompany_Localizations_CreatedDate");

            entity.HasIndex(e => e.EntityId, "IX_ContractingCompany_Localizations_EntityId");

            entity.HasIndex(e => e.IsDeleted, "IX_ContractingCompany_Localizations_IsDeleted");

            entity.HasIndex(e => e.LanguageLocale, "IX_ContractingCompany_Localizations_LanguageLocale");

            entity.HasIndex(e => e.TenantId, "IX_ContractingCompany_Localizations_TenantId");

            entity.HasIndex(e => new { e.TenantId, e.LanguageLocale, e.EntityId }, "IX_ContractingCompany_Localizations_Tenant_Locale_Company");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasDefaultValue("");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.LanguageLocale)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.Entity).WithMany(p => p.ContractingCompanyLocalizations).HasForeignKey(d => d.EntityId);

            entity.HasOne(d => d.LanguageLocaleNavigation).WithMany(p => p.ContractingCompanyLocalizations).HasForeignKey(d => d.LanguageLocale);
        });

        modelBuilder.Entity<ContractingDevice>(entity =>
        {
            entity.HasIndex(e => e.ContractingCompanyId, "IX_ContractingDevices_ContractingCompanyId");

            entity.HasIndex(e => e.CreatedDate, "IX_ContractingDevices_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_ContractingDevices_IsDeleted");

            entity.HasIndex(e => e.TenantId, "IX_ContractingDevices_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.ContractingCompany).WithMany(p => p.ContractingDevices).HasForeignKey(d => d.ContractingCompanyId);
        });

        modelBuilder.Entity<Counter>(entity =>
        {
            entity.HasKey(e => new { e.Key, e.Id }).HasName("PK_HangFire_Counter");

            entity.ToTable("Counter", "Hangfire");

            entity.Property(e => e.Key).HasMaxLength(100);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ExpireAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<Counter1>(entity =>
        {
            entity.HasKey(e => new { e.Key, e.Id }).HasName("PK_HangFire_Counter");

            entity.ToTable("Counter", "HangfireDev");

            entity.Property(e => e.Key).HasMaxLength(100);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ExpireAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<Crew>(entity =>
        {
            entity.HasIndex(e => e.ContractTypeId, "IX_Crews_ContractTypeId");

            entity.HasIndex(e => e.ContractingCompanyId, "IX_Crews_ContractingCompanyId");

            entity.HasIndex(e => e.CreatedDate, "IX_Crews_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_Crews_IsDeleted");

            entity.HasIndex(e => e.LicenseTypeId, "IX_Crews_LicenseTypeId");

            entity.HasIndex(e => e.NationalityId, "IX_Crews_NationalityId");

            entity.HasIndex(e => e.TenantId, "IX_Crews_TenantId");

            entity.HasIndex(e => e.TypeId, "IX_Crews_TypeId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Address).HasMaxLength(2000);
            entity.Property(e => e.CardNationalId).HasMaxLength(200);
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.LicenseNumber).HasMaxLength(200);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.ContractType).WithMany(p => p.Crews).HasForeignKey(d => d.ContractTypeId);

            entity.HasOne(d => d.ContractingCompany).WithMany(p => p.Crews).HasForeignKey(d => d.ContractingCompanyId);

            entity.HasOne(d => d.LicenseType).WithMany(p => p.Crews).HasForeignKey(d => d.LicenseTypeId);

            entity.HasOne(d => d.Nationality).WithMany(p => p.Crews).HasForeignKey(d => d.NationalityId);

            entity.HasOne(d => d.Type).WithMany(p => p.Crews).HasForeignKey(d => d.TypeId);
        });

        modelBuilder.Entity<CrewLocalization>(entity =>
        {
            entity.ToTable("Crew_Localizations");

            entity.HasIndex(e => e.CreatedDate, "IX_Crew_Localizations_CreatedDate");

            entity.HasIndex(e => e.EntityId, "IX_Crew_Localizations_EntityId");

            entity.HasIndex(e => e.IsDeleted, "IX_Crew_Localizations_IsDeleted");

            entity.HasIndex(e => e.LanguageLocale, "IX_Crew_Localizations_LanguageLocale");

            entity.HasIndex(e => e.TenantId, "IX_Crew_Localizations_TenantId");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasDefaultValue("");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.LanguageLocale)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.Entity).WithMany(p => p.CrewLocalizations).HasForeignKey(d => d.EntityId);

            entity.HasOne(d => d.LanguageLocaleNavigation).WithMany(p => p.CrewLocalizations).HasForeignKey(d => d.LanguageLocale);
        });

        modelBuilder.Entity<CrewOperationalPlan>(entity =>
        {
            entity.HasKey(e => new { e.CrewId, e.OperationalPlansId });

            entity.HasIndex(e => e.CreatedDate, "IX_CrewOperationalPlans_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_CrewOperationalPlans_IsDeleted");

            entity.HasIndex(e => e.OperationalPlansId, "IX_CrewOperationalPlans_OperationalPlansId");

            entity.HasIndex(e => e.TenantId, "IX_CrewOperationalPlans_TenantId");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasDefaultValue("");
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.Crew).WithMany(p => p.CrewOperationalPlans).HasForeignKey(d => d.CrewId);

            entity.HasOne(d => d.OperationalPlans).WithMany(p => p.CrewOperationalPlans).HasForeignKey(d => d.OperationalPlansId);
        });

        modelBuilder.Entity<CrewType>(entity =>
        {
            entity.ToTable("CrewType");

            entity.HasIndex(e => e.CreatedDate, "IX_CrewType_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_CrewType_IsDeleted");

            entity.HasIndex(e => e.TenantId, "IX_CrewType_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<Dictionary>(entity =>
        {
            entity.ToTable("Dictionary");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<DictionaryLocaization>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.LanguageLocale });

            entity.ToTable("DictionaryLocaization");

            entity.HasIndex(e => e.LanguageLocale, "IX_DictionaryLocaization_LanguageLocale");

            entity.Property(e => e.LanguageLocale)
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.HasOne(d => d.IdNavigation).WithMany(p => p.DictionaryLocaizations).HasForeignKey(d => d.Id);

            entity.HasOne(d => d.LanguageLocaleNavigation).WithMany(p => p.DictionaryLocaizations).HasForeignKey(d => d.LanguageLocale);
        });

        modelBuilder.Entity<DisposalPoint>(entity =>
        {
            entity.HasIndex(e => e.CategoryId, "IX_DisposalPoints_CategoryId");

            entity.HasIndex(e => e.ContractTypeId, "IX_DisposalPoints_ContractTypeId");

            entity.HasIndex(e => e.ContractingCompanyId, "IX_DisposalPoints_ContractingCompanyId");

            entity.HasIndex(e => e.CreatedDate, "IX_DisposalPoints_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_DisposalPoints_IsDeleted");

            entity.HasIndex(e => e.TenantId, "IX_DisposalPoints_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.Category).WithMany(p => p.DisposalPoints).HasForeignKey(d => d.CategoryId);

            entity.HasOne(d => d.ContractType).WithMany(p => p.DisposalPoints)
                .HasForeignKey(d => d.ContractTypeId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(d => d.ContractingCompany).WithMany(p => p.DisposalPoints)
                .HasForeignKey(d => d.ContractingCompanyId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<DisposalPointCategory>(entity =>
        {
            entity.ToTable("DisposalPointCategory");

            entity.HasIndex(e => e.CreatedDate, "IX_DisposalPointCategory_CreatedDate");

            entity.HasIndex(e => e.DictionaryId, "IX_DisposalPointCategory_DictionaryId");

            entity.HasIndex(e => e.IsDeleted, "IX_DisposalPointCategory_IsDeleted");

            entity.HasIndex(e => e.TenantId, "IX_DisposalPointCategory_TenantId");

            entity.Property(e => e.ColorHex).HasMaxLength(200);
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.Dictionary).WithMany(p => p.DisposalPointCategories).HasForeignKey(d => d.DictionaryId);
        });

        modelBuilder.Entity<DisposalPointLocalization>(entity =>
        {
            entity.ToTable("DisposalPoint_Localizations");

            entity.HasIndex(e => e.CreatedDate, "IX_DisposalPoint_Localizations_CreatedDate");

            entity.HasIndex(e => e.EntityId, "IX_DisposalPoint_Localizations_EntityId");

            entity.HasIndex(e => e.IsDeleted, "IX_DisposalPoint_Localizations_IsDeleted");

            entity.HasIndex(e => e.LanguageLocale, "IX_DisposalPoint_Localizations_LanguageLocale");

            entity.HasIndex(e => e.TenantId, "IX_DisposalPoint_Localizations_TenantId");

            entity.HasIndex(e => new { e.TenantId, e.LanguageLocale, e.EntityId }, "IX_DisposalPoint_Localizations_Tenant_Locale_Point");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasDefaultValue("");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.LanguageLocale)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.Entity).WithMany(p => p.DisposalPointLocalizations).HasForeignKey(d => d.EntityId);

            entity.HasOne(d => d.LanguageLocaleNavigation).WithMany(p => p.DisposalPointLocalizations).HasForeignKey(d => d.LanguageLocale);
        });

        modelBuilder.Entity<DriverOperationalPlan>(entity =>
        {
            entity.ToTable("DriverOperationalPlan");

            entity.HasIndex(e => e.CreatedDate, "IX_DriverOperationalPlan_CreatedDate");

            entity.HasIndex(e => e.DriverId, "IX_DriverOperationalPlan_DriverId");

            entity.HasIndex(e => e.IsDeleted, "IX_DriverOperationalPlan_IsDeleted");

            entity.HasIndex(e => e.OperationalPlansId, "IX_DriverOperationalPlan_OperationalPlansId");

            entity.HasIndex(e => e.TenantId, "IX_DriverOperationalPlan_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.Driver).WithMany(p => p.DriverOperationalPlans).HasForeignKey(d => d.DriverId);

            entity.HasOne(d => d.OperationalPlans).WithMany(p => p.DriverOperationalPlans).HasForeignKey(d => d.OperationalPlansId);
        });

        modelBuilder.Entity<DriverTrip>(entity =>
        {
            entity.ToTable("DriverTrip");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.Driver).WithMany(p => p.DriverTrips).HasForeignKey(d => d.DriverId);

            entity.HasOne(d => d.Trip).WithMany(p => p.DriverTrips).HasForeignKey(d => d.TripId);
        });

        modelBuilder.Entity<DynamicServiceProcessLog>(entity =>
        {
            entity.ToTable("DynamicServiceProcessLog");

            entity.HasIndex(e => e.ContractId, "IX_DynamicServiceProcessLog_ContractId");

            entity.HasIndex(e => e.ContractServiceId, "IX_DynamicServiceProcessLog_ContractServiceId");

            entity.HasIndex(e => e.CreatedDate, "IX_DynamicServiceProcessLog_CreatedDate");

            entity.HasIndex(e => e.LogDateTime, "IX_DynamicServiceProcessLog_LogDateTime");

            entity.HasIndex(e => e.OperationalPlanId, "IX_DynamicServiceProcessLog_OperationalPlanId");

            entity.HasIndex(e => e.ServiceGroupId, "IX_DynamicServiceProcessLog_ServiceGroupId");

            entity.HasIndex(e => e.TenantId, "IX_DynamicServiceProcessLog_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ContractCompletionPercentage).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);
            entity.Property(e => e.OperationalPlanCompletionPercentage).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.ServiceCompletionPercentage).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.ServiceGroupCompletionPercentage).HasColumnType("decimal(18, 6)");
        });

        modelBuilder.Entity<ErrorsLocalization>(entity =>
        {
            entity.ToTable("ErrorsLocalization");

            entity.HasIndex(e => new { e.Key, e.Locale }, "UniqueKey_Key_Locale").IsUnique();

            entity.Property(e => e.Key)
                .HasMaxLength(200)
                .HasDefaultValue("");
            entity.Property(e => e.Locale)
                .HasMaxLength(2)
                .HasDefaultValue("");
            entity.Property(e => e.Text)
                .HasMaxLength(200)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<GeometryType>(entity =>
        {
            entity.ToTable("GeometryType");

            entity.HasIndex(e => e.CreatedDate, "IX_GeometryType_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_GeometryType_IsDeleted");

            entity.HasIndex(e => e.TenantId, "IX_GeometryType_TenantId");

            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);
        });

        modelBuilder.Entity<Hash>(entity =>
        {
            entity.HasKey(e => new { e.Key, e.Field }).HasName("PK_HangFire_Hash");

            entity.ToTable("Hash", "Hangfire");

            entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Hash_ExpireAt").HasFilter("([ExpireAt] IS NOT NULL)");

            entity.Property(e => e.Key).HasMaxLength(100);
            entity.Property(e => e.Field).HasMaxLength(100);
        });

        modelBuilder.Entity<Hash1>(entity =>
        {
            entity.HasKey(e => new { e.Key, e.Field }).HasName("PK_HangFire_Hash");

            entity.ToTable("Hash", "HangfireDev");

            entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Hash_ExpireAt").HasFilter("([ExpireAt] IS NOT NULL)");

            entity.Property(e => e.Key).HasMaxLength(100);
            entity.Property(e => e.Field).HasMaxLength(100);
        });

        modelBuilder.Entity<Job>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_HangFire_Job");

            entity.ToTable("Job", "Hangfire");

            entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Job_ExpireAt").HasFilter("([ExpireAt] IS NOT NULL)");

            entity.HasIndex(e => e.StateName, "IX_HangFire_Job_StateName").HasFilter("([StateName] IS NOT NULL)");

            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            entity.Property(e => e.StateName).HasMaxLength(20);
        });

        modelBuilder.Entity<Job1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_HangFire_Job");

            entity.ToTable("Job", "HangfireDev");

            entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Job_ExpireAt").HasFilter("([ExpireAt] IS NOT NULL)");

            entity.HasIndex(e => e.StateName, "IX_HangFire_Job_StateName").HasFilter("([StateName] IS NOT NULL)");

            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            entity.Property(e => e.StateName).HasMaxLength(20);
        });

        modelBuilder.Entity<JobParameter>(entity =>
        {
            entity.HasKey(e => new { e.JobId, e.Name }).HasName("PK_HangFire_JobParameter");

            entity.ToTable("JobParameter", "Hangfire");

            entity.Property(e => e.Name).HasMaxLength(40);

            entity.HasOne(d => d.Job).WithMany(p => p.JobParameters)
                .HasForeignKey(d => d.JobId)
                .HasConstraintName("FK_HangFire_JobParameter_Job");
        });

        modelBuilder.Entity<JobParameter1>(entity =>
        {
            entity.HasKey(e => new { e.JobId, e.Name }).HasName("PK_HangFire_JobParameter");

            entity.ToTable("JobParameter", "HangfireDev");

            entity.Property(e => e.Name).HasMaxLength(40);

            entity.HasOne(d => d.Job).WithMany(p => p.JobParameter1s)
                .HasForeignKey(d => d.JobId)
                .HasConstraintName("FK_HangFire_JobParameter_Job");
        });

        modelBuilder.Entity<JobQueue>(entity =>
        {
            entity.HasKey(e => new { e.Queue, e.Id }).HasName("PK_HangFire_JobQueue");

            entity.ToTable("JobQueue", "Hangfire");

            entity.HasIndex(e => new { e.Queue, e.FetchedAt, e.Id, e.JobId }, "idx_JobQueue_Queue_FetchedAt");

            entity.Property(e => e.Queue).HasMaxLength(50);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.FetchedAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<JobQueue1>(entity =>
        {
            entity.HasKey(e => new { e.Queue, e.Id }).HasName("PK_HangFire_JobQueue");

            entity.ToTable("JobQueue", "HangfireDev");

            entity.Property(e => e.Queue).HasMaxLength(50);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.FetchedAt).HasColumnType("datetime");
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

        modelBuilder.Entity<LicenseType>(entity =>
        {
            entity.ToTable("LicenseType");

            entity.HasIndex(e => e.CreatedDate, "IX_LicenseType_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_LicenseType_IsDeleted");

            entity.HasIndex(e => e.TenantId, "IX_LicenseType_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<LicenseTypeLocalization>(entity =>
        {
            entity.ToTable("LicenseType_Localizations");

            entity.HasIndex(e => e.CreatedDate, "IX_LicenseType_Localizations_CreatedDate");

            entity.HasIndex(e => e.EntityId, "IX_LicenseType_Localizations_EntityId");

            entity.HasIndex(e => e.IsDeleted, "IX_LicenseType_Localizations_IsDeleted");

            entity.HasIndex(e => e.LanguageLocale, "IX_LicenseType_Localizations_LanguageLocale");

            entity.HasIndex(e => e.TenantId, "IX_LicenseType_Localizations_TenantId");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasDefaultValue("");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.LanguageLocale)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.Entity).WithMany(p => p.LicenseTypeLocalizations).HasForeignKey(d => d.EntityId);

            entity.HasOne(d => d.LanguageLocaleNavigation).WithMany(p => p.LicenseTypeLocalizations).HasForeignKey(d => d.LanguageLocale);
        });

        modelBuilder.Entity<List>(entity =>
        {
            entity.HasKey(e => new { e.Key, e.Id }).HasName("PK_HangFire_List");

            entity.ToTable("List", "Hangfire");

            entity.HasIndex(e => e.ExpireAt, "IX_HangFire_List_ExpireAt").HasFilter("([ExpireAt] IS NOT NULL)");

            entity.Property(e => e.Key).HasMaxLength(100);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ExpireAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<List1>(entity =>
        {
            entity.HasKey(e => new { e.Key, e.Id }).HasName("PK_HangFire_List");

            entity.ToTable("List", "HangfireDev");

            entity.HasIndex(e => e.ExpireAt, "IX_HangFire_List_ExpireAt").HasFilter("([ExpireAt] IS NOT NULL)");

            entity.Property(e => e.Key).HasMaxLength(100);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ExpireAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<LocalizationVersion>(entity =>
        {
            entity.HasKey(e => new { e.Localizer, e.Version });

            entity.ToTable("LocalizationVersion");

            entity.Property(e => e.Localizer).HasMaxLength(225);
            entity.Property(e => e.Version).HasMaxLength(5);
        });

        modelBuilder.Entity<Lookup>(entity =>
        {
            entity.ToTable("Lookup", "System");

            entity.HasIndex(e => e.CategoryId, "IX_Lookup_CategoryId");

            entity.HasIndex(e => e.CreatedDate, "IX_Lookup_CreatedDate");

            entity.HasIndex(e => e.DictionaryId, "IX_Lookup_DictionaryId");

            entity.HasIndex(e => e.IsDeleted, "IX_Lookup_IsDeleted");

            entity.HasIndex(e => e.TenantId, "IX_Lookup_TenantId");

            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.Category).WithMany(p => p.Lookups).HasForeignKey(d => d.CategoryId);

            entity.HasOne(d => d.Dictionary).WithMany(p => p.Lookups).HasForeignKey(d => d.DictionaryId);
        });

        modelBuilder.Entity<LookupCategory>(entity =>
        {
            entity.ToTable("LookupCategory", "System");

            entity.HasIndex(e => e.CreatedDate, "IX_LookupCategory_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_LookupCategory_IsDeleted");

            entity.HasIndex(e => e.TenantId, "IX_LookupCategory_TenantId");

            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);
        });

        modelBuilder.Entity<Nationality>(entity =>
        {
            entity.ToTable("Nationality");

            entity.HasIndex(e => e.CreatedDate, "IX_Nationality_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_Nationality_IsDeleted");

            entity.HasIndex(e => e.TenantId, "IX_Nationality_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.ToTable("Notification");

            entity.HasIndex(e => e.CreatedDate, "IX_Notification_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_Notification_IsDeleted");

            entity.HasIndex(e => e.Locale, "IX_Notification_Locale");

            entity.HasIndex(e => e.NotificationTypeId, "IX_Notification_NotificationTypeId");

            entity.HasIndex(e => e.TenantId, "IX_Notification_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.Locale)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Message).HasMaxLength(200);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);
            entity.Property(e => e.Subject).HasMaxLength(200);

            entity.HasOne(d => d.LocaleNavigation).WithMany(p => p.Notifications).HasForeignKey(d => d.Locale);

            entity.HasOne(d => d.NotificationType).WithMany(p => p.Notifications).HasForeignKey(d => d.NotificationTypeId);
        });

        modelBuilder.Entity<NotificationType>(entity =>
        {
            entity.ToTable("NotificationType");

            entity.HasIndex(e => e.EditDictionaryId, "IX_NotificationType_EditDictionaryId");

            entity.HasIndex(e => e.IsDeleted, "IX_NotificationType_IsDeleted");

            entity.HasIndex(e => e.MessageDictionaryId, "IX_NotificationType_MessageDictionaryId");

            entity.HasIndex(e => e.TitleDictionaryId, "IX_NotificationType_TitleDictionaryId");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.EditDictionary).WithMany(p => p.NotificationTypeEditDictionaries).HasForeignKey(d => d.EditDictionaryId);

            entity.HasOne(d => d.MessageDictionary).WithMany(p => p.NotificationTypeMessageDictionaries)
                .HasForeignKey(d => d.MessageDictionaryId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.TitleDictionary).WithMany(p => p.NotificationTypeTitleDictionaries)
                .HasForeignKey(d => d.TitleDictionaryId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<NotificationTypeEntry>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.NotificationTypeId });

            entity.HasIndex(e => e.IsDeleted, "IX_NotificationTypeEntries_IsDeleted");

            entity.HasIndex(e => e.NotificationTypeId, "IX_NotificationTypeEntries_NotificationTypeId");

            entity.Property(e => e.StringValue).HasMaxLength(200);

            entity.HasOne(d => d.NotificationType).WithMany(p => p.NotificationTypeEntries).HasForeignKey(d => d.NotificationTypeId);
        });

        modelBuilder.Entity<OperationPlanLocalization>(entity =>
        {
            entity.ToTable("OperationPlan_Localizations");

            entity.HasIndex(e => e.CreatedDate, "IX_OperationPlan_Localizations_CreatedDate");

            entity.HasIndex(e => e.EntityId, "IX_OperationPlan_Localizations_EntityId");

            entity.HasIndex(e => e.IsDeleted, "IX_OperationPlan_Localizations_IsDeleted");

            entity.HasIndex(e => e.LanguageLocale, "IX_OperationPlan_Localizations_LanguageLocale");

            entity.HasIndex(e => e.TenantId, "IX_OperationPlan_Localizations_TenantId");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasDefaultValue("");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.LanguageLocale)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.Entity).WithMany(p => p.OperationPlanLocalizations).HasForeignKey(d => d.EntityId);

            entity.HasOne(d => d.LanguageLocaleNavigation).WithMany(p => p.OperationPlanLocalizations).HasForeignKey(d => d.LanguageLocale);
        });

        modelBuilder.Entity<OperationPlanMonthlyFrequencyDay>(entity =>
        {
            entity.HasIndex(e => e.CreatedDate, "IX_OperationPlanMonthlyFrequencyDays_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_OperationPlanMonthlyFrequencyDays_IsDeleted");

            entity.HasIndex(e => e.OperationalPlansId, "IX_OperationPlanMonthlyFrequencyDays_OperationalPlansId");

            entity.HasIndex(e => e.TenantId, "IX_OperationPlanMonthlyFrequencyDays_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.OperationalPlans).WithMany(p => p.OperationPlanMonthlyFrequencyDays).HasForeignKey(d => d.OperationalPlansId);
        });

        modelBuilder.Entity<OperationalPlan>(entity =>
        {
            entity.HasIndex(e => e.ContractId, "IX_OperationalPlans_ContractId");

            entity.HasIndex(e => e.ContractServiceId, "IX_OperationalPlans_ContractServiceId");

            entity.HasIndex(e => e.ContractingCompanyId, "IX_OperationalPlans_ContractingCompanyId");

            entity.HasIndex(e => e.CreatedDate, "IX_OperationalPlans_CreatedDate");

            entity.HasIndex(e => e.DisposalPointId, "IX_OperationalPlans_DisposalPointId");

            entity.HasIndex(e => e.DriverId, "IX_OperationalPlans_DriverId");

            entity.HasIndex(e => e.IsDeleted, "IX_OperationalPlans_IsDeleted");

            entity.HasIndex(e => e.OvernightPointId, "IX_OperationalPlans_OvernightPointId");

            entity.HasIndex(e => e.SupervisorId, "IX_OperationalPlans_SupervisorId");

            entity.HasIndex(e => e.TenantId, "IX_OperationalPlans_TenantId");

            entity.HasIndex(e => e.VehicleId, "IX_OperationalPlans_VehicleId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ContractServiceId).HasDefaultValue(new Guid("00000000-0000-0000-0000-000000000000"));
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);
            entity.Property(e => e.MonthlyDays).HasMaxLength(200);
            entity.Property(e => e.ReferenceCode).HasMaxLength(200);
            entity.Property(e => e.Status).HasDefaultValue(9);
            entity.Property(e => e.TotalTripsCompletionPercentaion).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Contract).WithMany(p => p.OperationalPlans)
                .HasForeignKey(d => d.ContractId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.ContractService).WithMany(p => p.OperationalPlans).HasForeignKey(d => d.ContractServiceId);

            entity.HasOne(d => d.ContractingCompany).WithMany(p => p.OperationalPlans).HasForeignKey(d => d.ContractingCompanyId);

            entity.HasOne(d => d.DisposalPoint).WithMany(p => p.OperationalPlans).HasForeignKey(d => d.DisposalPointId);

            entity.HasOne(d => d.Driver).WithMany(p => p.OperationalPlanDrivers).HasForeignKey(d => d.DriverId);

            entity.HasOne(d => d.OvernightPoint).WithMany(p => p.OperationalPlans).HasForeignKey(d => d.OvernightPointId);

            entity.HasOne(d => d.Supervisor).WithMany(p => p.OperationalPlanSupervisors).HasForeignKey(d => d.SupervisorId);

            entity.HasOne(d => d.Vehicle).WithMany(p => p.OperationalPlans).HasForeignKey(d => d.VehicleId);
        });

        modelBuilder.Entity<OperationalPlanDetail>(entity =>
        {
            entity.HasIndex(e => e.BinId, "IX_OperationalPlanDetails_BinId");

            entity.HasIndex(e => e.ContractServiceMapGeometryId, "IX_OperationalPlanDetails_ContractServiceMapGeometryId");

            entity.HasIndex(e => e.CreatedDate, "IX_OperationalPlanDetails_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_OperationalPlanDetails_IsDeleted");

            entity.HasIndex(e => e.OperationalPlanId, "IX_OperationalPlanDetails_OperationalPlanId");

            entity.HasIndex(e => e.TenantId, "IX_OperationalPlanDetails_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);
            entity.Property(e => e.StreetWeightPercentage).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TagId).HasMaxLength(200);

            entity.HasOne(d => d.Bin).WithMany(p => p.OperationalPlanDetails).HasForeignKey(d => d.BinId);

            entity.HasOne(d => d.ContractServiceMapGeometry).WithMany(p => p.OperationalPlanDetails)
                .HasForeignKey(d => d.ContractServiceMapGeometryId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(d => d.OperationalPlan).WithMany(p => p.OperationalPlanDetails)
                .HasForeignKey(d => d.OperationalPlanId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<OperationalPlansDay>(entity =>
        {
            entity.HasKey(e => new { e.OperationalPlansId, e.WeekDaysId });

            entity.ToTable("OperationalPlansDay");

            entity.HasIndex(e => e.CreatedDate, "IX_OperationalPlansDay_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_OperationalPlansDay_IsDeleted");

            entity.HasIndex(e => e.TenantId, "IX_OperationalPlansDay_TenantId");

            entity.HasIndex(e => e.WeekDaysId, "IX_OperationalPlansDay_WeekDaysId");

            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.OperationalPlans).WithMany(p => p.OperationalPlansDays).HasForeignKey(d => d.OperationalPlansId);

            entity.HasOne(d => d.WeekDays).WithMany(p => p.OperationalPlansDays)
                .HasForeignKey(d => d.WeekDaysId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<OvernightPoint>(entity =>
        {
            entity.HasIndex(e => e.ContractTypeId, "IX_OvernightPoints_ContractTypeId");

            entity.HasIndex(e => e.ContractingCompanyId, "IX_OvernightPoints_ContractingCompanyId");

            entity.HasIndex(e => e.CreatedDate, "IX_OvernightPoints_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_OvernightPoints_IsDeleted");

            entity.HasIndex(e => e.TenantId, "IX_OvernightPoints_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.ContractType).WithMany(p => p.OvernightPoints)
                .HasForeignKey(d => d.ContractTypeId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(d => d.ContractingCompany).WithMany(p => p.OvernightPoints).HasForeignKey(d => d.ContractingCompanyId);
        });

        modelBuilder.Entity<OvernightPointLocalization>(entity =>
        {
            entity.ToTable("OvernightPoint_Localizations");

            entity.HasIndex(e => e.CreatedDate, "IX_OvernightPoint_Localizations_CreatedDate");

            entity.HasIndex(e => e.EntityId, "IX_OvernightPoint_Localizations_EntityId");

            entity.HasIndex(e => e.IsDeleted, "IX_OvernightPoint_Localizations_IsDeleted");

            entity.HasIndex(e => e.LanguageLocale, "IX_OvernightPoint_Localizations_LanguageLocale");

            entity.HasIndex(e => e.TenantId, "IX_OvernightPoint_Localizations_TenantId");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasDefaultValue("");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.LanguageLocale)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.Entity).WithMany(p => p.OvernightPointLocalizations).HasForeignKey(d => d.EntityId);

            entity.HasOne(d => d.LanguageLocaleNavigation).WithMany(p => p.OvernightPointLocalizations).HasForeignKey(d => d.LanguageLocale);
        });

        modelBuilder.Entity<Privilege>(entity =>
        {
            entity.HasIndex(e => e.CreatedDate, "IX_Privileges_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_Privileges_IsDeleted");

            entity.HasIndex(e => e.PrivilegeGroupId, "IX_Privileges_PrivilegeGroupId");

            entity.HasIndex(e => e.TenantId, "IX_Privileges_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.Dictionary).WithMany(p => p.Privileges)
                .HasForeignKey(d => d.DictionaryId)
                .HasConstraintName("FK_Privileges_Dictionary");

            entity.HasOne(d => d.PrivilegeGroup).WithMany(p => p.Privileges)
                .HasForeignKey(d => d.PrivilegeGroupId)
                .OnDelete(DeleteBehavior.SetNull);
        });

        modelBuilder.Entity<PrivilegeGroup>(entity =>
        {
            entity.HasIndex(e => e.CreatedDate, "IX_PrivilegeGroups_CreatedDate");

            entity.HasIndex(e => e.PrivilegeGroupId, "IX_PrivilegeGroups_PrivilegeGroupId");

            entity.HasIndex(e => e.TenantId, "IX_PrivilegeGroups_TenantId");

            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.Dictionary).WithMany(p => p.PrivilegeGroups)
                .HasForeignKey(d => d.DictionaryId)
                .HasConstraintName("FK_PrivilegeGroups_Dictionary");
        });

        modelBuilder.Entity<ReportAggregate>(entity =>
        {
            entity.HasIndex(e => e.CreatedDate, "IX_ReportAggregates_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_ReportAggregates_IsDeleted");

            entity.HasIndex(e => e.ReportEngineId, "IX_ReportAggregates_ReportEngineId");

            entity.HasIndex(e => e.TenantId, "IX_ReportAggregates_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.FieldKey).HasMaxLength(200);
            entity.Property(e => e.Function).HasMaxLength(200);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.ReportEngine).WithMany(p => p.ReportAggregates).HasForeignKey(d => d.ReportEngineId);
        });

        modelBuilder.Entity<ReportColumn>(entity =>
        {
            entity.HasIndex(e => e.CreatedDate, "IX_ReportColumns_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_ReportColumns_IsDeleted");

            entity.HasIndex(e => e.ReportEngineId, "IX_ReportColumns_ReportEngineId");

            entity.HasIndex(e => e.TenantId, "IX_ReportColumns_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.Expression).HasMaxLength(200);
            entity.Property(e => e.FieldKey).HasMaxLength(200);
            entity.Property(e => e.Format).HasMaxLength(200);
            entity.Property(e => e.Label).HasMaxLength(200);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.ReportEngine).WithMany(p => p.ReportColumns).HasForeignKey(d => d.ReportEngineId);
        });

        modelBuilder.Entity<ReportEngine>(entity =>
        {
            entity.HasIndex(e => e.CreatedDate, "IX_ReportEngines_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_ReportEngines_IsDeleted");

            entity.HasIndex(e => e.TenantId, "IX_ReportEngines_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.FooterTemplate).HasMaxLength(4000);
            entity.Property(e => e.HeaderTemplate).HasMaxLength(4000);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.PrimaryDateField).HasMaxLength(200);
        });

        modelBuilder.Entity<ReportFilter>(entity =>
        {
            entity.HasIndex(e => e.CreatedDate, "IX_ReportFilters_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_ReportFilters_IsDeleted");

            entity.HasIndex(e => e.ReportEngineId, "IX_ReportFilters_ReportEngineId");

            entity.HasIndex(e => e.TenantId, "IX_ReportFilters_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.FieldKey).HasMaxLength(200);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);
            entity.Property(e => e.Value1).HasMaxLength(200);
            entity.Property(e => e.Value2).HasMaxLength(200);

            entity.HasOne(d => d.ReportEngine).WithMany(p => p.ReportFilters).HasForeignKey(d => d.ReportEngineId);
        });

        modelBuilder.Entity<ReportGroup>(entity =>
        {
            entity.HasIndex(e => e.CreatedDate, "IX_ReportGroups_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_ReportGroups_IsDeleted");

            entity.HasIndex(e => e.ReportEngineId, "IX_ReportGroups_ReportEngineId");

            entity.HasIndex(e => e.TenantId, "IX_ReportGroups_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.FieldKey).HasMaxLength(200);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.ReportEngine).WithMany(p => p.ReportGroups).HasForeignKey(d => d.ReportEngineId);
        });

        modelBuilder.Entity<ReportRunHistory>(entity =>
        {
            entity.HasIndex(e => e.CreatedDate, "IX_ReportRunHistories_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_ReportRunHistories_IsDeleted");

            entity.HasIndex(e => e.ReportEngineId, "IX_ReportRunHistories_ReportEngineId");

            entity.HasIndex(e => e.TenantId, "IX_ReportRunHistories_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ArtifactPath).HasMaxLength(200);
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.ErrorMessage).HasMaxLength(200);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.ReportEngine).WithMany(p => p.ReportRunHistories).HasForeignKey(d => d.ReportEngineId);
        });

        modelBuilder.Entity<ReportSchedule>(entity =>
        {
            entity.HasIndex(e => e.CreatedDate, "IX_ReportSchedules_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_ReportSchedules_IsDeleted");

            entity.HasIndex(e => e.ReportEngineId, "IX_ReportSchedules_ReportEngineId");

            entity.HasIndex(e => e.TenantId, "IX_ReportSchedules_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.BodyTemplate).HasMaxLength(200);
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.Culture).HasMaxLength(10);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);
            entity.Property(e => e.Recipients).HasMaxLength(200);
            entity.Property(e => e.SubjectTemplate).HasMaxLength(200);
            entity.Property(e => e.Timezone).HasMaxLength(200);

            entity.HasOne(d => d.ReportEngine).WithMany(p => p.ReportSchedules).HasForeignKey(d => d.ReportEngineId);
        });

        modelBuilder.Entity<ReportSort>(entity =>
        {
            entity.HasIndex(e => e.CreatedDate, "IX_ReportSorts_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_ReportSorts_IsDeleted");

            entity.HasIndex(e => e.ReportEngineId, "IX_ReportSorts_ReportEngineId");

            entity.HasIndex(e => e.TenantId, "IX_ReportSorts_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.FieldKey).HasMaxLength(200);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.ReportEngine).WithMany(p => p.ReportSorts).HasForeignKey(d => d.ReportEngineId);
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasIndex(e => e.CreatedDate, "IX_Roles_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_Roles_IsDeleted");

            entity.HasIndex(e => e.TenantId, "IX_Roles_TenantId");

            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);
        });

        modelBuilder.Entity<RoleLocalization>(entity =>
        {
            entity.ToTable("Role_Localizations");

            entity.HasIndex(e => e.CreatedDate, "IX_Role_Localizations_CreatedDate");

            entity.HasIndex(e => e.EntityId, "IX_Role_Localizations_EntityId");

            entity.HasIndex(e => e.IsDeleted, "IX_Role_Localizations_IsDeleted");

            entity.HasIndex(e => e.LanguageLocale, "IX_Role_Localizations_LanguageLocale");

            entity.HasIndex(e => e.TenantId, "IX_Role_Localizations_TenantId");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasDefaultValue("");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.LanguageLocale)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.Entity).WithMany(p => p.RoleLocalizations).HasForeignKey(d => d.EntityId);

            entity.HasOne(d => d.LanguageLocaleNavigation).WithMany(p => p.RoleLocalizations).HasForeignKey(d => d.LanguageLocale);
        });

        modelBuilder.Entity<RolePrivilege>(entity =>
        {
            entity.HasKey(e => new { e.RoleId, e.PrivilegeId });

            entity.HasIndex(e => e.CreatedDate, "IX_RolePrivileges_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_RolePrivileges_IsDeleted");

            entity.HasIndex(e => e.PrivilegeId, "IX_RolePrivileges_PrivilegeId");

            entity.HasIndex(e => e.TenantId, "IX_RolePrivileges_TenantId");

            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.Privilege).WithMany(p => p.RolePrivileges)
                .HasForeignKey(d => d.PrivilegeId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Role).WithMany(p => p.RolePrivileges).HasForeignKey(d => d.RoleId);
        });

        modelBuilder.Entity<Schema>(entity =>
        {
            entity.HasKey(e => e.Version).HasName("PK_HangFire_Schema");

            entity.ToTable("Schema", "Hangfire");

            entity.Property(e => e.Version).ValueGeneratedNever();
        });

        modelBuilder.Entity<Schema1>(entity =>
        {
            entity.HasKey(e => e.Version).HasName("PK_HangFire_Schema");

            entity.ToTable("Schema", "HangfireDev");

            entity.Property(e => e.Version).ValueGeneratedNever();
        });

        modelBuilder.Entity<SeedingHistory>(entity =>
        {
            entity.HasKey(e => new { e.SeedTypeName, e.SeedType, e.SeedVersion });

            entity.ToTable("__SeedingHistory");

            entity.Property(e => e.SeedTypeName).HasMaxLength(225);
            entity.Property(e => e.SeedType).HasMaxLength(100);
            entity.Property(e => e.SeedVersion).HasMaxLength(5);
        });

        modelBuilder.Entity<QA.Server>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_HangFire_Server");

            entity.ToTable("Server", "Hangfire");

            entity.HasIndex(e => e.LastHeartbeat, "IX_HangFire_Server_LastHeartbeat");

            entity.Property(e => e.Id).HasMaxLength(200);
            entity.Property(e => e.LastHeartbeat).HasColumnType("datetime");
        });

        modelBuilder.Entity<QA.Server1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_HangFire_Server");

            entity.ToTable("Server", "HangfireDev");

            entity.HasIndex(e => e.LastHeartbeat, "IX_HangFire_Server_LastHeartbeat");

            entity.Property(e => e.Id).HasMaxLength(200);
            entity.Property(e => e.LastHeartbeat).HasColumnType("datetime");
        });

        modelBuilder.Entity<QA.Service>(entity =>
        {
            entity.HasIndex(e => e.CreatedDate, "IX_Services_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_Services_IsDeleted");

            entity.HasIndex(e => e.ServiceGroupId, "IX_Services_ServiceGroupId");

            entity.HasIndex(e => e.TenantId, "IX_Services_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);

            entity.HasOne(d => d.ServiceGroup).WithMany(p => p.Services).HasForeignKey(d => d.ServiceGroupId);
        });

        modelBuilder.Entity<ServiceCrewType>(entity =>
        {
            entity.HasKey(e => new { e.ServiceId, e.CrewTypeId });

            entity.ToTable("ServiceCrewType");

            entity.HasIndex(e => e.CreatedDate, "IX_ServiceCrewType_CreatedDate");

            entity.HasIndex(e => e.CrewTypeId, "IX_ServiceCrewType_CrewTypeId");

            entity.HasIndex(e => e.IsDeleted, "IX_ServiceCrewType_IsDeleted");

            entity.HasIndex(e => e.TenantId, "IX_ServiceCrewType_TenantId");

            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.CrewType).WithMany(p => p.ServiceCrewTypes).HasForeignKey(d => d.CrewTypeId);

            entity.HasOne(d => d.Service).WithMany(p => p.ServiceCrewTypes).HasForeignKey(d => d.ServiceId);
        });

        modelBuilder.Entity<ServiceGeometryType>(entity =>
        {
            entity.HasKey(e => new { e.ServiceId, e.GeometryTypeId });

            entity.ToTable("ServiceGeometryType");

            entity.HasIndex(e => e.CreatedDate, "IX_ServiceGeometryType_CreatedDate");

            entity.HasIndex(e => e.GeometryTypeId, "IX_ServiceGeometryType_GeometryTypeId");

            entity.HasIndex(e => e.IsDeleted, "IX_ServiceGeometryType_IsDeleted");

            entity.HasIndex(e => e.TenantId, "IX_ServiceGeometryType_TenantId");

            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.GeometryType).WithMany(p => p.ServiceGeometryTypes).HasForeignKey(d => d.GeometryTypeId);

            entity.HasOne(d => d.Service).WithMany(p => p.ServiceGeometryTypes).HasForeignKey(d => d.ServiceId);
        });

        modelBuilder.Entity<ServiceGroup>(entity =>
        {
            entity.HasIndex(e => e.CreatedDate, "IX_ServiceGroups_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_ServiceGroups_IsDeleted");

            entity.HasIndex(e => e.ServiceGroupTypeId, "IX_ServiceGroups_ServiceGroupTypeID");

            entity.HasIndex(e => e.TenantId, "IX_ServiceGroups_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.ServiceGroupTypeId).HasColumnName("ServiceGroupTypeID");

            entity.HasOne(d => d.ServiceGroupType).WithMany(p => p.ServiceGroups).HasForeignKey(d => d.ServiceGroupTypeId);
        });

        modelBuilder.Entity<ServiceGroupContractType>(entity =>
        {
            entity.HasKey(e => new { e.ServiceGroupId, e.ContractTypeId });

            entity.ToTable("ServiceGroupContractType");

            entity.HasIndex(e => e.ContractTypeId, "IX_ServiceGroupContractType_ContractTypeId");

            entity.HasIndex(e => e.CreatedDate, "IX_ServiceGroupContractType_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_ServiceGroupContractType_IsDeleted");

            entity.HasIndex(e => e.TenantId, "IX_ServiceGroupContractType_TenantId");

            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.ContractType).WithMany(p => p.ServiceGroupContractTypes).HasForeignKey(d => d.ContractTypeId);

            entity.HasOne(d => d.ServiceGroup).WithMany(p => p.ServiceGroupContractTypes).HasForeignKey(d => d.ServiceGroupId);
        });

        modelBuilder.Entity<ServiceGroupLocalization>(entity =>
        {
            entity.ToTable("ServiceGroup_Localizations");

            entity.HasIndex(e => e.CreatedDate, "IX_ServiceGroup_Localizations_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_ServiceGroup_Localizations_IsDeleted");

            entity.HasIndex(e => e.TenantId, "IX_ServiceGroup_Localizations_TenantId");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasDefaultValue("");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.LanguageLocale)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.Entity).WithMany(p => p.ServiceGroupLocalizations).HasForeignKey(d => d.EntityId);

            entity.HasOne(d => d.LanguageLocaleNavigation).WithMany(p => p.ServiceGroupLocalizations).HasForeignKey(d => d.LanguageLocale);
        });

        modelBuilder.Entity<ServiceGroupServiceGroupType>(entity =>
        {
            entity.HasKey(e => new { e.ServiceGroupId, e.ServiceGroupTypeId });

            entity.ToTable("ServiceGroup_ServiceGroupType");

            entity.HasIndex(e => e.CreatedDate, "IX_ServiceGroup_ServiceGroupType_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_ServiceGroup_ServiceGroupType_IsDeleted");

            entity.HasIndex(e => e.ServiceGroupTypeId, "IX_ServiceGroup_ServiceGroupType_ServiceGroupTypeId");

            entity.HasIndex(e => e.TenantId, "IX_ServiceGroup_ServiceGroupType_TenantId");

            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.ServiceGroup).WithMany(p => p.ServiceGroupServiceGroupTypes).HasForeignKey(d => d.ServiceGroupId);

            entity.HasOne(d => d.ServiceGroupType).WithMany(p => p.ServiceGroupServiceGroupTypes).HasForeignKey(d => d.ServiceGroupTypeId);
        });

        modelBuilder.Entity<ServiceGroupType>(entity =>
        {
            entity.HasIndex(e => e.CreatedDate, "IX_ServiceGroupTypes_CreatedDate");

            entity.HasIndex(e => e.DictionaryId, "IX_ServiceGroupTypes_DictionaryID");

            entity.HasIndex(e => e.IsDeleted, "IX_ServiceGroupTypes_IsDeleted");

            entity.HasIndex(e => e.TenantId, "IX_ServiceGroupTypes_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.DictionaryId).HasColumnName("DictionaryID");
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.Dictionary).WithMany(p => p.ServiceGroupTypes).HasForeignKey(d => d.DictionaryId);
        });

        modelBuilder.Entity<ServiceLocalization>(entity =>
        {
            entity.ToTable("Service_Localizations");

            entity.HasIndex(e => e.CreatedDate, "IX_Service_Localizations_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_Service_Localizations_IsDeleted");

            entity.HasIndex(e => e.TenantId, "IX_Service_Localizations_TenantId");

            entity.HasIndex(e => new { e.TenantId, e.LanguageLocale, e.EntityId }, "IX_Service_Localizations_Tenant_Locale_Service");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasDefaultValue("");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.LanguageLocale)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.Entity).WithMany(p => p.ServiceLocalizations).HasForeignKey(d => d.EntityId);

            entity.HasOne(d => d.LanguageLocaleNavigation).WithMany(p => p.ServiceLocalizations).HasForeignKey(d => d.LanguageLocale);
        });

        modelBuilder.Entity<ServiceUiConfiguration>(entity =>
        {
            entity.ToTable("ServiceUiConfiguration");

            entity.HasIndex(e => e.CreatedDate, "IX_ServiceUiConfiguration_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_ServiceUiConfiguration_IsDeleted");

            entity.HasIndex(e => e.ServiceId, "IX_ServiceUiConfiguration_ServiceId").IsUnique();

            entity.HasIndex(e => e.TenantId, "IX_ServiceUiConfiguration_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.IsOptional).HasDefaultValue(true);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.Service).WithOne(p => p.ServiceUiConfiguration)
                .HasForeignKey<ServiceUiConfiguration>(d => d.ServiceId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<ServiceVehicleType>(entity =>
        {
            entity.HasKey(e => new { e.ServiceId, e.VehicleTypeId });

            entity.ToTable("ServiceVehicleType");

            entity.HasIndex(e => e.CreatedDate, "IX_ServiceVehicleType_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_ServiceVehicleType_IsDeleted");

            entity.HasIndex(e => e.TenantId, "IX_ServiceVehicleType_TenantId");

            entity.HasIndex(e => e.VehicleTypeId, "IX_ServiceVehicleType_VehicleTypeId");

            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.Service).WithMany(p => p.ServiceVehicleTypes).HasForeignKey(d => d.ServiceId);

            entity.HasOne(d => d.VehicleType).WithMany(p => p.ServiceVehicleTypes).HasForeignKey(d => d.VehicleTypeId);
        });

        modelBuilder.Entity<Set>(entity =>
        {
            entity.HasKey(e => new { e.Key, e.Value }).HasName("PK_HangFire_Set");

            entity.ToTable("Set", "Hangfire");

            entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Set_ExpireAt").HasFilter("([ExpireAt] IS NOT NULL)");

            entity.HasIndex(e => new { e.Key, e.Score }, "IX_HangFire_Set_Score");

            entity.Property(e => e.Key).HasMaxLength(100);
            entity.Property(e => e.Value).HasMaxLength(256);
            entity.Property(e => e.ExpireAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<Set1>(entity =>
        {
            entity.HasKey(e => new { e.Key, e.Value }).HasName("PK_HangFire_Set");

            entity.ToTable("Set", "HangfireDev");

            entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Set_ExpireAt").HasFilter("([ExpireAt] IS NOT NULL)");

            entity.HasIndex(e => new { e.Key, e.Score }, "IX_HangFire_Set_Score");

            entity.Property(e => e.Key).HasMaxLength(100);
            entity.Property(e => e.Value).HasMaxLength(256);
            entity.Property(e => e.ExpireAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<SpInsertDebugLog>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK__Sp_Inser__5E5486483DF4929A");

            entity.ToTable("Sp_InsertDebugLog");

            entity.Property(e => e.CreatedDate)
                .HasPrecision(3)
                .HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.ProcedureName).HasMaxLength(128);
            entity.Property(e => e.StepName).HasMaxLength(200);
        });

        modelBuilder.Entity<State>(entity =>
        {
            entity.HasKey(e => new { e.JobId, e.Id }).HasName("PK_HangFire_State");

            entity.ToTable("State", "Hangfire");

            entity.HasIndex(e => e.CreatedAt, "IX_HangFire_State_CreatedAt");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(20);
            entity.Property(e => e.Reason).HasMaxLength(100);

            entity.HasOne(d => d.Job).WithMany(p => p.States)
                .HasForeignKey(d => d.JobId)
                .HasConstraintName("FK_HangFire_State_Job");
        });

        modelBuilder.Entity<State1>(entity =>
        {
            entity.HasKey(e => new { e.JobId, e.Id }).HasName("PK_HangFire_State");

            entity.ToTable("State", "HangfireDev");

            entity.HasIndex(e => e.CreatedAt, "IX_HangFire_State_CreatedAt");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(20);
            entity.Property(e => e.Reason).HasMaxLength(100);

            entity.HasOne(d => d.Job).WithMany(p => p.State1s)
                .HasForeignKey(d => d.JobId)
                .HasConstraintName("FK_HangFire_State_Job");
        });

        modelBuilder.Entity<SupportedLanguage>(entity =>
        {
            entity.HasKey(e => e.Language);

            entity.Property(e => e.Language)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Direction).HasMaxLength(3);
            entity.Property(e => e.Name).HasMaxLength(225);
        });

        modelBuilder.Entity<SupportedLanguagesNew>(entity =>
        {
            entity.ToTable("SupportedLanguagesNew");

            entity.HasIndex(e => e.Language, "IX_SupportedLanguagesNew_Language").IsUnique();

            entity.Property(e => e.Direction)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Language)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Trip>(entity =>
        {
            entity.HasIndex(e => e.CreatedDate, "IX_Trips_CreatedDate");

            entity.HasIndex(e => e.DisposalPointId, "IX_Trips_DisposalPointId");

            entity.HasIndex(e => e.DriverId, "IX_Trips_DriverId");

            entity.HasIndex(e => e.IsDeleted, "IX_Trips_IsDeleted");

            entity.HasIndex(e => new { e.IsDeleted, e.TenantId }, "IX_Trips_IsDeleted_TenantId");

            entity.HasIndex(e => e.OperationManagerId, "IX_Trips_OperationManagerId");

            entity.HasIndex(e => e.OperationalPlansId, "IX_Trips_OperationalPlansId");

            entity.HasIndex(e => e.OvernightPointId, "IX_Trips_OvernightPointId");

            entity.HasIndex(e => e.TenantId, "IX_Trips_TenantId");

            entity.HasIndex(e => e.TripDate, "IX_Trips_TripDate");

            entity.HasIndex(e => e.VehicleId, "IX_Trips_VehicleId");

            entity.HasIndex(e => e.VehicleId1, "IX_Trips_VehicleId1");

            entity.HasIndex(e => new { e.VehicleId, e.StartTrip, e.EndTrip }, "IX_Trips_VehicleId_StartTrip_EndTrip");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);
            entity.Property(e => e.ReferenceCode).HasMaxLength(200);

            entity.HasOne(d => d.DisposalPoint).WithMany(p => p.Trips).HasForeignKey(d => d.DisposalPointId);

            entity.HasOne(d => d.Driver).WithMany(p => p.TripDrivers).HasForeignKey(d => d.DriverId);

            entity.HasOne(d => d.OperationManager).WithMany(p => p.TripOperationManagers).HasForeignKey(d => d.OperationManagerId);

            entity.HasOne(d => d.OperationalPlans).WithMany(p => p.Trips)
                .HasForeignKey(d => d.OperationalPlansId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.OvernightPoint).WithMany(p => p.Trips).HasForeignKey(d => d.OvernightPointId);

            entity.HasOne(d => d.Vehicle).WithMany(p => p.TripVehicles).HasForeignKey(d => d.VehicleId);

            entity.HasOne(d => d.VehicleId1Navigation).WithMany(p => p.TripVehicleId1Navigations).HasForeignKey(d => d.VehicleId1);
        });

        modelBuilder.Entity<TripDetail>(entity =>
        {
            entity.HasIndex(e => new { e.TripId, e.TenantId }, "IDX_TripDetails_TripId_TenantID");

            entity.HasIndex(e => e.BinId, "IX_TripDetails_BinId");

            entity.HasIndex(e => e.ContractServiceMapGeometryId, "IX_TripDetails_ContractServiceMapGeometryId");

            entity.HasIndex(e => e.CreatedDate, "IX_TripDetails_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_TripDetails_IsDeleted");

            entity.HasIndex(e => e.TagId, "IX_TripDetails_TagId");

            entity.HasIndex(e => new { e.TagId, e.TripId }, "IX_TripDetails_TagId_TripId");

            entity.HasIndex(e => e.TenantId, "IX_TripDetails_TenantId");

            entity.HasIndex(e => e.TripId, "IX_TripDetails_TripId");

            entity.HasIndex(e => new { e.TripId, e.IsDeleted, e.TenantId }, "IX_TripDetails_TripId_IsDeleted_TenantId");

            entity.HasIndex(e => new { e.TripId, e.TagId, e.IsDeleted }, "IX_TripDetails_TripId_TagId_IsDeleted");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);
            entity.Property(e => e.ReferenceCode).HasMaxLength(200);
            entity.Property(e => e.StreetWeightPercentage).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TagHash)
                .HasMaxLength(32)
                .HasComputedColumnSql("(CONVERT([varbinary](32),hashbytes('SHA2_256',CONVERT([nvarchar](4000),[TagId]))))", true);
            entity.Property(e => e.TagId).HasMaxLength(200);

            entity.HasOne(d => d.Bin).WithMany(p => p.TripDetails).HasForeignKey(d => d.BinId);

            entity.HasOne(d => d.ContractServiceMapGeometry).WithMany(p => p.TripDetails)
                .HasForeignKey(d => d.ContractServiceMapGeometryId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(d => d.Trip).WithMany(p => p.TripDetails).HasForeignKey(d => d.TripId);
        });

        modelBuilder.Entity<TripDetailsFile>(entity =>
        {
            entity.ToTable("TripDetailsFile");

            entity.HasIndex(e => e.CreatedDate, "IX_TripDetailsFile_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_TripDetailsFile_IsDeleted");

            entity.HasIndex(e => e.TenantId, "IX_TripDetailsFile_TenantId");

            entity.HasIndex(e => e.TripDetailsId, "IX_TripDetailsFile_TripDetailsId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.FileName).HasMaxLength(200);
            entity.Property(e => e.FilePath).HasMaxLength(200);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.TripDetails).WithMany(p => p.TripDetailsFiles).HasForeignKey(d => d.TripDetailsId);
        });

        modelBuilder.Entity<TripDetailsProcessingSummary>(entity =>
        {
            entity.ToTable("TripDetailsProcessingSummary");

            entity.HasIndex(e => e.TenantId, "IX_TDPS_TenantId");

            entity.HasIndex(e => e.ManualLiftReasonLookupId, "IX_TripDetailsProcessingSummary_ManualLiftReasonLookupId");

            entity.HasIndex(e => e.StatusLookupId, "IX_TripDetailsProcessingSummary_StatusLookupId");

            entity.HasIndex(e => e.TenantId, "IX_TripDetailsProcessingSummary_TenantId");

            entity.HasIndex(e => e.TripDetailsId, "IX_TripDetailsProcessingSummary_TripDetailsId").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CompilationReason).HasMaxLength(200);
            entity.Property(e => e.CompletionPercentage).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasDefaultValue("");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);
            entity.Property(e => e.SweptAreaSquareMeters).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalDistance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.WaterUsedLiters).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.ManualLiftReasonLookup).WithMany(p => p.TripDetailsProcessingSummaryManualLiftReasonLookups).HasForeignKey(d => d.ManualLiftReasonLookupId);

            entity.HasOne(d => d.StatusLookup).WithMany(p => p.TripDetailsProcessingSummaryStatusLookups).HasForeignKey(d => d.StatusLookupId);

            entity.HasOne(d => d.TripDetails).WithOne(p => p.TripDetailsProcessingSummary).HasForeignKey<TripDetailsProcessingSummary>(d => d.TripDetailsId);
        });

        modelBuilder.Entity<TripFile>(entity =>
        {
            entity.ToTable("TripFile");

            entity.HasIndex(e => e.CreatedDate, "IX_TripFile_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_TripFile_IsDeleted");

            entity.HasIndex(e => e.TenantId, "IX_TripFile_TenantId");

            entity.HasIndex(e => e.TripId, "IX_TripFile_TripId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.FileName).HasMaxLength(200);
            entity.Property(e => e.FilePath).HasMaxLength(200);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.Trip).WithMany(p => p.TripFiles).HasForeignKey(d => d.TripId);
        });

        modelBuilder.Entity<TripLocalizationLocalization>(entity =>
        {
            entity.ToTable("TripLocalization_Localizations");

            entity.HasIndex(e => e.CreatedByChecksum, "IX_TripLocalization_Localizations_CreatedByChecksum");

            entity.HasIndex(e => e.CreatedDate, "IX_TripLocalization_Localizations_CreatedDate");

            entity.HasIndex(e => e.EntityId, "IX_TripLocalization_Localizations_EntityId");

            entity.HasIndex(e => new { e.EntityId, e.LanguageLocale }, "IX_TripLocalization_Localizations_Entity_Locale");

            entity.HasIndex(e => e.IsDeleted, "IX_TripLocalization_Localizations_IsDeleted");

            entity.HasIndex(e => e.LanguageLocale, "IX_TripLocalization_Localizations_LanguageLocale");

            entity.HasIndex(e => e.TenantId, "IX_TripLocalization_Localizations_TenantId");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasDefaultValue("");
            entity.Property(e => e.CreatedByChecksum).HasComputedColumnSql("(checksum([CreatedBy]))", true);
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.LanguageLocale)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.Entity).WithMany(p => p.TripLocalizationLocalizations).HasForeignKey(d => d.EntityId);

            entity.HasOne(d => d.LanguageLocaleNavigation).WithMany(p => p.TripLocalizationLocalizations).HasForeignKey(d => d.LanguageLocale);
        });

        modelBuilder.Entity<TripProcessingSummary>(entity =>
        {
            entity.ToTable("TripProcessingSummary");

            entity.HasIndex(e => e.CreatedDate, "IX_TripProcessingSummary_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_TripProcessingSummary_IsDeleted");

            entity.HasIndex(e => e.TenantId, "IX_TripProcessingSummary_TenantId");

            entity.HasIndex(e => e.TripId, "IX_TripProcessingSummary_TripId").IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CompletionPercentage).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);
            entity.Property(e => e.TotalDistance).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Trip).WithOne(p => p.TripProcessingSummary).HasForeignKey<TripProcessingSummary>(d => d.TripId);
        });

        modelBuilder.Entity<Vehicle>(entity =>
        {
            entity.ToTable("Vehicle");

            entity.HasIndex(e => e.ContractTypeId, "IX_Vehicle_ContractTypeId");

            entity.HasIndex(e => e.ContractingCompanyId, "IX_Vehicle_ContractingCompanyId");

            entity.HasIndex(e => e.CreatedDate, "IX_Vehicle_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_Vehicle_IsDeleted");

            entity.HasIndex(e => e.TenantId, "IX_Vehicle_TenantId");

            entity.HasIndex(e => new { e.TenantId, e.IsDeleted, e.VehicleTypeId }, "IX_Vehicle_Tenant_IsDeleted_VehicleTypeId");

            entity.HasIndex(e => e.VehicleTypeId, "IX_Vehicle_VehicleTypeId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);
            entity.Property(e => e.PlateChar).HasMaxLength(50);
            entity.Property(e => e.PlateNumber).HasMaxLength(20);
            entity.Property(e => e.ReferenceCode).HasMaxLength(200);
            entity.Property(e => e.Vin)
                .HasMaxLength(200)
                .HasColumnName("VIN");

            entity.HasOne(d => d.ContractType).WithMany(p => p.Vehicles).HasForeignKey(d => d.ContractTypeId);

            entity.HasOne(d => d.ContractingCompany).WithMany(p => p.Vehicles).HasForeignKey(d => d.ContractingCompanyId);

            entity.HasOne(d => d.VehicleType).WithMany(p => p.Vehicles).HasForeignKey(d => d.VehicleTypeId);
        });

        modelBuilder.Entity<VehicleAvlDataPatch>(entity =>
        {
            entity.ToTable("VehicleAvlDataPatch");

            entity.HasIndex(e => e.IsDeleted, "IX_VehicleAvlDataPatch_IsDeleted");

            entity.HasIndex(e => e.TenantId, "IX_VehicleAvlDataPatch_TenantId");

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

        modelBuilder.Entity<VehicleAvlDataPatchRecovery>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VehicleA__3214EC072E7819AD");

            entity.ToTable("VehicleAvlDataPatchRecovery");

            entity.HasIndex(e => e.IsDeleted, "IX_VehicleAvlDataPatchRecovery_IsDeleted");

            entity.HasIndex(e => e.MovementTime, "IX_VehicleAvlDataPatchRecovery_MovementTime");

            entity.HasIndex(e => e.TenantId, "IX_VehicleAvlDataPatchRecovery_TenantId");

            entity.HasIndex(e => new { e.Tag, e.VehicleId, e.MovementTime }, "IX_VehicleAvlPatch_Tag_Vehicle_Time");

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

        modelBuilder.Entity<VehicleAvlDataPatchRecoveryV2>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VehicleA__3214EC077270951D");

            entity.ToTable("VehicleAvlDataPatchRecovery_v2");

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

        modelBuilder.Entity<VehicleLatestPoint>(entity =>
        {
            entity.ToTable("VehicleLatestPoint");

            entity.HasIndex(e => e.CreatedDate, "IX_VehicleLatestPoint_CreatedDate");

            entity.HasIndex(e => e.TenantId, "IX_VehicleLatestPoint_TenantId");

            entity.HasIndex(e => e.TripId, "IX_VehicleLatestPoint_TripId");

            entity.HasIndex(e => e.VehicleId, "IX_VehicleLatestPoint_VehicleId").IsUnique();

            entity.HasIndex(e => e.Id, "idx_VehicleLatestPoint_Id");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AnalogInput1).HasMaxLength(200);
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.DigitalInput1).HasMaxLength(200);
            entity.Property(e => e.Imei)
                .HasMaxLength(200)
                .HasColumnName("IMEI");
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);
            entity.Property(e => e.PlateNumber).HasMaxLength(200);
            entity.Property(e => e.RowVersion)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.Trip).WithMany(p => p.VehicleLatestPoints).HasForeignKey(d => d.TripId);

            entity.HasOne(d => d.Vehicle).WithOne(p => p.VehicleLatestPoint)
                .HasForeignKey<VehicleLatestPoint>(d => d.VehicleId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<VehicleOperationalPlan>(entity =>
        {
            entity.ToTable("VehicleOperationalPlan");

            entity.HasIndex(e => e.CreatedDate, "IX_VehicleOperationalPlan_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_VehicleOperationalPlan_IsDeleted");

            entity.HasIndex(e => e.OperationalPlansId, "IX_VehicleOperationalPlan_OperationalPlansId");

            entity.HasIndex(e => e.TenantId, "IX_VehicleOperationalPlan_TenantId");

            entity.HasIndex(e => e.VehicleId, "IX_VehicleOperationalPlan_VehicleId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.OperationalPlans).WithMany(p => p.VehicleOperationalPlans).HasForeignKey(d => d.OperationalPlansId);

            entity.HasOne(d => d.Vehicle).WithMany(p => p.VehicleOperationalPlans)
                .HasForeignKey(d => d.VehicleId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<VehicleTrip>(entity =>
        {
            entity.ToTable("VehicleTrip");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.Trip).WithMany(p => p.VehicleTrips).HasForeignKey(d => d.TripId);

            entity.HasOne(d => d.Vehicle).WithMany(p => p.VehicleTrips).HasForeignKey(d => d.VehicleId);
        });

        modelBuilder.Entity<VehicleType>(entity =>
        {
            entity.ToTable("VehicleType");

            entity.HasIndex(e => e.CreatedDate, "IX_VehicleType_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_VehicleType_IsDeleted");

            entity.HasIndex(e => e.TenantId, "IX_VehicleType_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<VehiclesAvlDatum>(entity =>
        {
            entity.HasIndex(e => e.CreatedDate, "IX_VehiclesAvlData_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_VehiclesAvlData_IsDeleted");

            entity.HasIndex(e => e.TenantId, "IX_VehiclesAvlData_TenantId");

            entity.HasIndex(e => e.TripId, "IX_VehiclesAvlData_TripId");

            entity.HasIndex(e => e.VehicleId, "IX_VehiclesAvlData_VehicleId");

            entity.HasIndex(e => new { e.TenantId, e.CreatedDate }, "idx_VehiclesAvlData_TenantId_CreatedDate");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AnalogInput1).HasMaxLength(200);
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.DigitalInput1).HasMaxLength(200);
            entity.Property(e => e.Imei)
                .HasMaxLength(200)
                .HasColumnName("IMEI");
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);
            entity.Property(e => e.PlateNumber).HasMaxLength(200);

            entity.HasOne(d => d.Trip).WithMany(p => p.VehiclesAvlData).HasForeignKey(d => d.TripId);

            entity.HasOne(d => d.Vehicle).WithMany(p => p.VehiclesAvlData)
                .HasForeignKey(d => d.VehicleId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<VwMapGeometry>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwMapGeometry");

            entity.Property(e => e.Tag).HasMaxLength(200);
        });

        modelBuilder.Entity<WeekDay>(entity =>
        {
            entity.HasIndex(e => e.CreatedDate, "IX_WeekDays_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_WeekDays_IsDeleted");

            entity.HasIndex(e => e.TenantId, "IX_WeekDays_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<WeekDaysLocalization>(entity =>
        {
            entity.ToTable("WeekDays_Localizations");

            entity.HasIndex(e => e.CreatedDate, "IX_WeekDays_Localizations_CreatedDate");

            entity.HasIndex(e => e.EntityId, "IX_WeekDays_Localizations_EntityId");

            entity.HasIndex(e => e.IsDeleted, "IX_WeekDays_Localizations_IsDeleted");

            entity.HasIndex(e => e.LanguageLocale, "IX_WeekDays_Localizations_LanguageLocale");

            entity.HasIndex(e => e.TenantId, "IX_WeekDays_Localizations_TenantId");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasDefaultValue("");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.LanguageLocale)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.Entity).WithMany(p => p.WeekDaysLocalizations).HasForeignKey(d => d.EntityId);

            entity.HasOne(d => d.LanguageLocaleNavigation).WithMany(p => p.WeekDaysLocalizations).HasForeignKey(d => d.LanguageLocale);
        });

        modelBuilder.Entity<Zone>(entity =>
        {
            entity.HasIndex(e => e.CreatedDate, "IX_Zones_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_Zones_IsDeleted");

            entity.HasIndex(e => e.TenantId, "IX_Zones_TenantId");

            entity.HasIndex(e => e.ZoneTypeId, "IX_Zones_ZoneTypeId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.ZoneType).WithMany(p => p.Zones).HasForeignKey(d => d.ZoneTypeId);
        });

        modelBuilder.Entity<ZoneType>(entity =>
        {
            entity.ToTable("ZoneType");

            entity.HasIndex(e => e.CreatedDate, "IX_ZoneType_CreatedDate");

            entity.HasIndex(e => e.IsDeleted, "IX_ZoneType_IsDeleted");

            entity.HasIndex(e => e.TenantId, "IX_ZoneType_TenantId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Color).HasMaxLength(200);
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);
        });

        modelBuilder.Entity<ZoneTypeLocalization>(entity =>
        {
            entity.ToTable("ZoneType_Localizations");

            entity.HasIndex(e => e.CreatedDate, "IX_ZoneType_Localizations_CreatedDate");

            entity.HasIndex(e => e.EntityId, "IX_ZoneType_Localizations_EntityId");

            entity.HasIndex(e => e.IsDeleted, "IX_ZoneType_Localizations_IsDeleted");

            entity.HasIndex(e => e.LanguageLocale, "IX_ZoneType_Localizations_LanguageLocale");

            entity.HasIndex(e => e.TenantId, "IX_ZoneType_Localizations_TenantId");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasDefaultValue("");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.LanguageLocale)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.Entity).WithMany(p => p.ZoneTypeLocalizations).HasForeignKey(d => d.EntityId);

            entity.HasOne(d => d.LanguageLocaleNavigation).WithMany(p => p.ZoneTypeLocalizations).HasForeignKey(d => d.LanguageLocale);
        });

        modelBuilder.Entity<ZonesLocalization>(entity =>
        {
            entity.ToTable("Zones_Localizations");

            entity.HasIndex(e => e.CreatedDate, "IX_Zones_Localizations_CreatedDate");

            entity.HasIndex(e => e.EntityId, "IX_Zones_Localizations_EntityId");

            entity.HasIndex(e => e.IsDeleted, "IX_Zones_Localizations_IsDeleted");

            entity.HasIndex(e => e.LanguageLocale, "IX_Zones_Localizations_LanguageLocale");

            entity.HasIndex(e => e.TenantId, "IX_Zones_Localizations_TenantId");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasDefaultValue("");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.LanguageLocale)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);

            entity.HasOne(d => d.Entity).WithMany(p => p.ZonesLocalizations).HasForeignKey(d => d.EntityId);

            entity.HasOne(d => d.LanguageLocaleNavigation).WithMany(p => p.ZonesLocalizations).HasForeignKey(d => d.LanguageLocale);
        });

        modelBuilder.Entity<ZonesVehicle>(entity =>
        {
            entity.HasKey(e => new { e.ZoneId, e.VehicleTypeId });

            entity.ToTable("Zones_Vehicles");

            entity.HasIndex(e => e.VehicleTypeId, "IX_Zones_Vehicles_VehicleTypeId");

            entity.HasOne(d => d.VehicleType).WithMany(p => p.ZonesVehicles).HasForeignKey(d => d.VehicleTypeId);

            entity.HasOne(d => d.Zone).WithMany(p => p.ZonesVehicles).HasForeignKey(d => d.ZoneId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
