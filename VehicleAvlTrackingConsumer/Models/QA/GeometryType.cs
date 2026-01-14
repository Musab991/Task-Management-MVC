using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class GeometryType
{
    public int Id { get; set; }

    public int Type { get; set; }

    public string? Description { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool IsDeleted { get; set; }

    public Guid TenantId { get; set; }

    public virtual ICollection<ServiceGeometryType> ServiceGeometryTypes { get; set; } = new List<ServiceGeometryType>();
}
