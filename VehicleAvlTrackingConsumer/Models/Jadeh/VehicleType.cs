using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh;

[Table("VehicleType")]
[Index("CreatedDate", Name = "IX_VehicleType_CreatedDate")]
[Index("IsDeleted", Name = "IX_VehicleType_IsDeleted")]
[Index("TenantId", Name = "IX_VehicleType_TenantId")]
public partial class VehicleType
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(200)]
    public string? Name { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    public string? Icon { get; set; }

    public int Type { get; set; }

    [InverseProperty("VehicleType")]
    public virtual ICollection<ServiceVehicleType> ServiceVehicleTypes { get; set; } = new List<ServiceVehicleType>();

    [InverseProperty("VehicleType")]
    public virtual ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();

    [InverseProperty("VehicleType")]
    public virtual ICollection<ZonesVehicle> ZonesVehicles { get; set; } = new List<ZonesVehicle>();
}
