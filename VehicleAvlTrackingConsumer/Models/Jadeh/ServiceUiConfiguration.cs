using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh;

[Table("ServiceUiConfiguration")]
[Index("CreatedDate", Name = "IX_ServiceUiConfiguration_CreatedDate")]
[Index("IsDeleted", Name = "IX_ServiceUiConfiguration_IsDeleted")]
[Index("ServiceId", Name = "IX_ServiceUiConfiguration_ServiceId", IsUnique = true)]
[Index("TenantId", Name = "IX_ServiceUiConfiguration_TenantId")]
public partial class ServiceUiConfiguration
{
    [Key]
    public Guid Id { get; set; }

    public Guid ServiceId { get; set; }

    public bool HasDriverName { get; set; }

    public bool HasDisposablePoint { get; set; }

    public bool HasOvernightPoint { get; set; }

    public bool HasVehicle { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
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

    [ForeignKey("ServiceId")]
    [InverseProperty("ServiceUiConfiguration")]
    public virtual Service Service { get; set; } = null!;
}
