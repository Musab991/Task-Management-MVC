using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[Index("ContractId", Name = "IX_OperationalPlans_ContractId")]
[Index("ContractServiceId", Name = "IX_OperationalPlans_ContractServiceId")]
[Index("ContractingCompanyId", Name = "IX_OperationalPlans_ContractingCompanyId")]
[Index("CreatedDate", Name = "IX_OperationalPlans_CreatedDate")]
[Index("DisposalPointId", Name = "IX_OperationalPlans_DisposalPointId")]
[Index("DriverId", Name = "IX_OperationalPlans_DriverId")]
[Index("IsDeleted", Name = "IX_OperationalPlans_IsDeleted")]
[Index("OvernightPointId", Name = "IX_OperationalPlans_OvernightPointId")]
[Index("SupervisorId", Name = "IX_OperationalPlans_SupervisorId")]
[Index("TenantId", Name = "IX_OperationalPlans_TenantId")]
[Index("VehicleId", Name = "IX_OperationalPlans_VehicleId")]
public partial class OperationalPlan
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(200)]
    public string? ReferenceCode { get; set; }

    public Guid? DriverId { get; set; }

    public Guid? DisposalPointId { get; set; }

    public Guid? OvernightPointId { get; set; }

    public Guid? VehicleId { get; set; }

    public Guid ContractId { get; set; }

    public int Status { get; set; }

    public double PlanCoverage { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    public DateTime EndDate { get; set; }

    public DateTime StartDate { get; set; }

    public Guid? ContractServiceId { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal TotalTripsCompletionPercentaion { get; set; }

    public double TripDurationHours { get; set; }

    public double ExpectedCoverage { get; set; }

    public int CountActiveTrip { get; set; }

    public Guid? SupervisorId { get; set; }

    public Guid ContractingCompanyId { get; set; }

    [StringLength(200)]
    public string? MonthlyDays { get; set; }

    public bool IsMonthly { get; set; }

    [ForeignKey("ContractId")]
    [InverseProperty("OperationalPlans")]
    public virtual Contract Contract { get; set; } = null!;

    [ForeignKey("ContractServiceId")]
    [InverseProperty("OperationalPlans")]
    public virtual ContractService? ContractService { get; set; }

    [ForeignKey("ContractingCompanyId")]
    [InverseProperty("OperationalPlans")]
    public virtual ContractingCompany ContractingCompany { get; set; } = null!;

    [InverseProperty("OperationalPlans")]
    public virtual ICollection<CrewOperationalPlan> CrewOperationalPlans { get; set; } = new List<CrewOperationalPlan>();

    [ForeignKey("DisposalPointId")]
    [InverseProperty("OperationalPlans")]
    public virtual DisposalPoint? DisposalPoint { get; set; }

    [ForeignKey("DriverId")]
    [InverseProperty("OperationalPlanDrivers")]
    public virtual Crew? Driver { get; set; }

    [InverseProperty("OperationalPlans")]
    public virtual ICollection<DriverOperationalPlan> DriverOperationalPlans { get; set; } = new List<DriverOperationalPlan>();

    [InverseProperty("Entity")]
    public virtual ICollection<OperationPlanLocalization> OperationPlanLocalizations { get; set; } = new List<OperationPlanLocalization>();

    [InverseProperty("OperationalPlans")]
    public virtual ICollection<OperationPlanMonthlyFrequencyDay> OperationPlanMonthlyFrequencyDays { get; set; } = new List<OperationPlanMonthlyFrequencyDay>();

    [InverseProperty("OperationalPlan")]
    public virtual ICollection<OperationalPlanDetail> OperationalPlanDetails { get; set; } = new List<OperationalPlanDetail>();

    [InverseProperty("OperationalPlans")]
    public virtual ICollection<OperationalPlansDay> OperationalPlansDays { get; set; } = new List<OperationalPlansDay>();

    [ForeignKey("OvernightPointId")]
    [InverseProperty("OperationalPlans")]
    public virtual OvernightPoint? OvernightPoint { get; set; }

    [ForeignKey("SupervisorId")]
    [InverseProperty("OperationalPlanSupervisors")]
    public virtual Crew? Supervisor { get; set; }

    [InverseProperty("OperationalPlans")]
    public virtual ICollection<Trip> Trips { get; set; } = new List<Trip>();

    [ForeignKey("VehicleId")]
    [InverseProperty("OperationalPlans")]
    public virtual Vehicle? Vehicle { get; set; }

    [InverseProperty("OperationalPlans")]
    public virtual ICollection<VehicleOperationalPlan> VehicleOperationalPlans { get; set; } = new List<VehicleOperationalPlan>();
}
