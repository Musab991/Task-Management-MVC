using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class CrewOperationalPlan
{
    public Guid CrewId { get; set; }

    public Guid OperationalPlansId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public Guid Id { get; set; }

    public bool IsDeleted { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public Guid TenantId { get; set; }

    public virtual Crew Crew { get; set; } = null!;

    public virtual OperationalPlan OperationalPlans { get; set; } = null!;
}
