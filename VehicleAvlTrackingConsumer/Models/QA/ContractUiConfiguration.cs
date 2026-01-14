using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class ContractUiConfiguration
{
    public Guid Id { get; set; }

    public bool HasDevices { get; set; }

    public bool HasBins { get; set; }

    public bool HasWorker { get; set; }

    public Guid ServiceGroupId { get; set; }

    public bool HasSupervisor { get; set; }

    public bool HasDisposablePoint { get; set; }

    public bool HasDriver { get; set; }

    public bool HasOvernightPoint { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public bool IsAllowedToAddShapeToOperationalPlan { get; set; }

    public bool IsAllowedToDeleteOperationalPlan { get; set; }

    public bool IsAllowedToUpdateCrew { get; set; }

    public bool IsAllowedToUpdateDriver { get; set; }

    public bool IsAllowedToUpdateTime { get; set; }

    public bool IsAllowedToUpdateVehicle { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public Guid TenantId { get; set; }

    public bool IsAllowedToUpdate { get; set; }

    public virtual ServiceGroup ServiceGroup { get; set; } = null!;
}
