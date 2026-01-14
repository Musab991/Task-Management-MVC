using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[Table("VehicleTrip")]
public partial class VehicleTrip
{
    [Key]
    public Guid Id { get; set; }

    public Guid TripId { get; set; }

    public Guid VehicleId { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public Guid TenantId { get; set; }

    [ForeignKey("TripId")]
    [InverseProperty("VehicleTrips")]
    public virtual Trip Trip { get; set; } = null!;

    [ForeignKey("VehicleId")]
    [InverseProperty("VehicleTrips")]
    public virtual Vehicle Vehicle { get; set; } = null!;
}
