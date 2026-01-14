using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class ServiceGeometryType
{
    public Guid ServiceId { get; set; }

    public int GeometryTypeId { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    public virtual GeometryType GeometryType { get; set; } = null!;

    public virtual Service Service { get; set; } = null!;
}
