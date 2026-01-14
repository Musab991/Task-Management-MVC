using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class OvernightPoint
{
    public Guid Id { get; set; }

    public Guid ContractingCompanyId { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    public Guid? ContractTypeId { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public string? GeometryJson { get; set; }

    public string? PropertiesJson { get; set; }

    public virtual ContractType? ContractType { get; set; }

    public virtual ContractingCompany ContractingCompany { get; set; } = null!;

    public virtual ICollection<OperationalPlan> OperationalPlans { get; set; } = new List<OperationalPlan>();

    public virtual ICollection<OvernightPointLocalization> OvernightPointLocalizations { get; set; } = new List<OvernightPointLocalization>();

    public virtual ICollection<Trip> Trips { get; set; } = new List<Trip>();
}
