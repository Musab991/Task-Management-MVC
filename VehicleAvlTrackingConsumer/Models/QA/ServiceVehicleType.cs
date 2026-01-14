using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class ServiceVehicleType
{
    public Guid ServiceId { get; set; }

    public Guid VehicleTypeId { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    public virtual Service Service { get; set; } = null!;

    public virtual VehicleType VehicleType { get; set; } = null!;
}
