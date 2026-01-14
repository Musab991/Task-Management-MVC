using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh;

[PrimaryKey("ServiceId", "VehicleTypeId")]
[Table("ServiceVehicleType")]
[Index("CreatedDate", Name = "IX_ServiceVehicleType_CreatedDate")]
[Index("IsDeleted", Name = "IX_ServiceVehicleType_IsDeleted")]
[Index("TenantId", Name = "IX_ServiceVehicleType_TenantId")]
[Index("VehicleTypeId", Name = "IX_ServiceVehicleType_VehicleTypeId")]
public partial class ServiceVehicleType
{
    [Key]
    public Guid ServiceId { get; set; }

    [Key]
    public Guid VehicleTypeId { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    [ForeignKey("ServiceId")]
    [InverseProperty("ServiceVehicleTypes")]
    public virtual Service Service { get; set; } = null!;

    [ForeignKey("VehicleTypeId")]
    [InverseProperty("ServiceVehicleTypes")]
    public virtual VehicleType VehicleType { get; set; } = null!;
}
