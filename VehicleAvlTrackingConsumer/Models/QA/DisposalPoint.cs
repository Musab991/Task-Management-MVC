using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class DisposalPoint
{
    public Guid Id { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    public Guid? ContractingCompanyId { get; set; }

    public Guid? ContractTypeId { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public int? CategoryId { get; set; }

    public string? GeometryJson { get; set; }

    public string? PropertiesJson { get; set; }

    public long TotalCapacity { get; set; }

    public virtual DisposalPointCategory? Category { get; set; }

    public virtual ContractType? ContractType { get; set; }

    public virtual ContractingCompany? ContractingCompany { get; set; }

    public virtual ICollection<DisposalPointLocalization> DisposalPointLocalizations { get; set; } = new List<DisposalPointLocalization>();

    public virtual ICollection<OperationalPlan> OperationalPlans { get; set; } = new List<OperationalPlan>();

    public virtual ICollection<Trip> Trips { get; set; } = new List<Trip>();
}
