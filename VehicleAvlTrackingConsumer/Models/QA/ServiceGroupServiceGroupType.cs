using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class ServiceGroupServiceGroupType
{
    public Guid ServiceGroupId { get; set; }

    public Guid ServiceGroupTypeId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    public bool IsDeleted { get; set; }

    public Guid Id { get; set; }

    public virtual ServiceGroup ServiceGroup { get; set; } = null!;

    public virtual ServiceGroupType ServiceGroupType { get; set; } = null!;
}
