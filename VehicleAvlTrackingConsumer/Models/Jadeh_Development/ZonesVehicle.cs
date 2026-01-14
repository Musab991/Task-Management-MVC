using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[PrimaryKey("ZoneId", "VehicleTypeId")]
[Table("Zones_Vehicles")]
[Index("VehicleTypeId", Name = "IX_Zones_Vehicles_VehicleTypeId")]
public partial class ZonesVehicle
{
    [Key]
    public Guid ZoneId { get; set; }

    [Key]
    public Guid VehicleTypeId { get; set; }

    public Guid Id { get; set; }

    [ForeignKey("VehicleTypeId")]
    [InverseProperty("ZonesVehicles")]
    public virtual VehicleType VehicleType { get; set; } = null!;

    [ForeignKey("ZoneId")]
    [InverseProperty("ZonesVehicles")]
    public virtual Zone Zone { get; set; } = null!;
}
