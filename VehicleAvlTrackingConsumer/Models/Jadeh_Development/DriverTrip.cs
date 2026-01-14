using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[Table("DriverTrip")]
public partial class DriverTrip
{
    [Key]
    public Guid Id { get; set; }

    public Guid DriverId { get; set; }

    public Guid TripId { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public Guid TenantId { get; set; }

    [ForeignKey("DriverId")]
    [InverseProperty("DriverTrips")]
    public virtual Crew Driver { get; set; } = null!;

    [ForeignKey("TripId")]
    [InverseProperty("DriverTrips")]
    public virtual Trip Trip { get; set; } = null!;
}
