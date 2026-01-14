using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class ServiceUiConfiguration
{
    public Guid Id { get; set; }

    public Guid ServiceId { get; set; }

    public bool HasDriverName { get; set; }

    public bool HasDisposablePoint { get; set; }

    public bool HasOvernightPoint { get; set; }

    public bool HasVehicle { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    public bool IsOptional { get; set; }

    public bool HasCrew { get; set; }

    public bool HasSupervisor { get; set; }

    public bool IsAllowedToAddShapeToOperationalPlan { get; set; }

    public bool IsAllowedToDeleteOperationalPlan { get; set; }

    public bool IsAllowedToUpdateCrew { get; set; }

    public bool IsAllowedToUpdateDriver { get; set; }

    public bool IsAllowedToUpdateTime { get; set; }

    public bool IsAllowedToUpdateVehicle { get; set; }

    public virtual Service Service { get; set; } = null!;
}
