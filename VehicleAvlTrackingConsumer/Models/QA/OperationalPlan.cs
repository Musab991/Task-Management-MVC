using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class OperationalPlan
{
    public Guid Id { get; set; }

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

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    public DateTime EndDate { get; set; }

    public DateTime StartDate { get; set; }

    public Guid? ContractServiceId { get; set; }

    public decimal TotalTripsCompletionPercentaion { get; set; }

    public double TripDurationHours { get; set; }

    public double ExpectedCoverage { get; set; }

    public int CountActiveTrip { get; set; }

    public Guid? SupervisorId { get; set; }

    public Guid ContractingCompanyId { get; set; }

    public string? MonthlyDays { get; set; }

    public bool IsMonthly { get; set; }

    public double TripCount { get; set; }

    public virtual Contract Contract { get; set; } = null!;

    public virtual ContractService? ContractService { get; set; }

    public virtual ContractingCompany ContractingCompany { get; set; } = null!;

    public virtual ICollection<CrewOperationalPlan> CrewOperationalPlans { get; set; } = new List<CrewOperationalPlan>();

    public virtual DisposalPoint? DisposalPoint { get; set; }

    public virtual Crew? Driver { get; set; }

    public virtual ICollection<DriverOperationalPlan> DriverOperationalPlans { get; set; } = new List<DriverOperationalPlan>();

    public virtual ICollection<OperationPlanLocalization> OperationPlanLocalizations { get; set; } = new List<OperationPlanLocalization>();

    public virtual ICollection<OperationPlanMonthlyFrequencyDay> OperationPlanMonthlyFrequencyDays { get; set; } = new List<OperationPlanMonthlyFrequencyDay>();

    public virtual ICollection<OperationalPlanDetail> OperationalPlanDetails { get; set; } = new List<OperationalPlanDetail>();

    public virtual ICollection<OperationalPlansDay> OperationalPlansDays { get; set; } = new List<OperationalPlansDay>();

    public virtual OvernightPoint? OvernightPoint { get; set; }

    public virtual Crew? Supervisor { get; set; }

    public virtual ICollection<Trip> Trips { get; set; } = new List<Trip>();

    public virtual Vehicle? Vehicle { get; set; }

    public virtual ICollection<VehicleOperationalPlan> VehicleOperationalPlans { get; set; } = new List<VehicleOperationalPlan>();
}
