using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[Index("ContractTypeId", Name = "IX_Crews_ContractTypeId")]
[Index("ContractingCompanyId", Name = "IX_Crews_ContractingCompanyId")]
[Index("CreatedDate", Name = "IX_Crews_CreatedDate")]
[Index("IsDeleted", Name = "IX_Crews_IsDeleted")]
[Index("LicenseTypeId", Name = "IX_Crews_LicenseTypeId")]
[Index("NationalityId", Name = "IX_Crews_NationalityId")]
[Index("TenantId", Name = "IX_Crews_TenantId")]
[Index("TypeId", Name = "IX_Crews_TypeId")]
public partial class Crew
{
    [Key]
    public Guid Id { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    [StringLength(2000)]
    public string? Address { get; set; }

    [StringLength(200)]
    public string? CardNationalId { get; set; }

    public Guid? TypeId { get; set; }

    [Column("DOB")]
    public DateTime? Dob { get; set; }

    public DateTime? LicenseExpiryDate { get; set; }

    [StringLength(200)]
    public string? LicenseNumber { get; set; }

    public Guid? LicenseTypeId { get; set; }

    public Guid? NationalityId { get; set; }

    public int NoOfExperinceYears { get; set; }

    public Guid? ContractTypeId { get; set; }

    public Guid? ContractingCompanyId { get; set; }

    public DateTime BirthDay { get; set; }

    [InverseProperty("Crew")]
    public virtual ApplicationUser? ApplicationUser { get; set; }

    [ForeignKey("ContractTypeId")]
    [InverseProperty("Crews")]
    public virtual ContractType? ContractType { get; set; }

    [ForeignKey("ContractingCompanyId")]
    [InverseProperty("Crews")]
    public virtual ContractingCompany? ContractingCompany { get; set; }

    [InverseProperty("Entity")]
    public virtual ICollection<CrewLocalization> CrewLocalizations { get; set; } = new List<CrewLocalization>();

    [InverseProperty("Crew")]
    public virtual ICollection<CrewOperationalPlan> CrewOperationalPlans { get; set; } = new List<CrewOperationalPlan>();

    [InverseProperty("Driver")]
    public virtual ICollection<DriverOperationalPlan> DriverOperationalPlans { get; set; } = new List<DriverOperationalPlan>();

    [InverseProperty("Driver")]
    public virtual ICollection<DriverTrip> DriverTrips { get; set; } = new List<DriverTrip>();

    [ForeignKey("LicenseTypeId")]
    [InverseProperty("Crews")]
    public virtual LicenseType? LicenseType { get; set; }

    [ForeignKey("NationalityId")]
    [InverseProperty("Crews")]
    public virtual Nationality? Nationality { get; set; }

    [InverseProperty("Driver")]
    public virtual ICollection<OperationalPlan> OperationalPlanDrivers { get; set; } = new List<OperationalPlan>();

    [InverseProperty("Supervisor")]
    public virtual ICollection<OperationalPlan> OperationalPlanSupervisors { get; set; } = new List<OperationalPlan>();

    [InverseProperty("Driver")]
    public virtual ICollection<Trip> TripDrivers { get; set; } = new List<Trip>();

    [InverseProperty("OperationManager")]
    public virtual ICollection<Trip> TripOperationManagers { get; set; } = new List<Trip>();

    [ForeignKey("TypeId")]
    [InverseProperty("Crews")]
    public virtual CrewType? Type { get; set; }
}
