using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[Index("CreatedDate", Name = "IX_ContractUiConfigurations_CreatedDate")]
[Index("IsDeleted", Name = "IX_ContractUiConfigurations_IsDeleted")]
[Index("ServiceGroupId", Name = "IX_ContractUiConfigurations_ServiceGroupId", IsUnique = true)]
[Index("TenantId", Name = "IX_ContractUiConfigurations_TenantId")]
public partial class ContractUiConfiguration
{
    [Key]
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

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public bool IsAllowedToAddShapeToOperationalPlan { get; set; }

    public bool IsAllowedToDeleteOperationalPlan { get; set; }

    public bool IsAllowedToUpdateCrew { get; set; }

    public bool IsAllowedToUpdateDriver { get; set; }

    public bool IsAllowedToUpdateTime { get; set; }

    public bool IsAllowedToUpdateVehicle { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public Guid TenantId { get; set; }

    [ForeignKey("ServiceGroupId")]
    [InverseProperty("ContractUiConfiguration")]
    public virtual ServiceGroup ServiceGroup { get; set; } = null!;
}
