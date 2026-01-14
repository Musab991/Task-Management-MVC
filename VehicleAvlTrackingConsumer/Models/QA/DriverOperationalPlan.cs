using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class DriverOperationalPlan
{
    public Guid Id { get; set; }

    public Guid DriverId { get; set; }

    public Guid OperationalPlansId { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    public bool IsMain { get; set; }

    public virtual Crew Driver { get; set; } = null!;

    public virtual OperationalPlan OperationalPlans { get; set; } = null!;
}
