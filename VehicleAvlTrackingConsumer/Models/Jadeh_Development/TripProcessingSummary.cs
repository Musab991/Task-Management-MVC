using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[Table("TripProcessingSummary")]
[Index("CreatedDate", Name = "IX_TripProcessingSummary_CreatedDate")]
[Index("IsDeleted", Name = "IX_TripProcessingSummary_IsDeleted")]
[Index("TenantId", Name = "IX_TripProcessingSummary_TenantId")]
[Index("TripId", Name = "IX_TripProcessingSummary_TripId", IsUnique = true)]
public partial class TripProcessingSummary
{
    [Key]
    public Guid Id { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal TotalDistance { get; set; }

    public bool IsWaterUsed { get; set; }

    public double ExpectedCovarge { get; set; }

    public bool IsFinalized { get; set; }

    public double ActualCovarge { get; set; }

    public Guid TripId { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    public DateTime? ActualEndTrip { get; set; }

    public DateTime? ActualStartTrip { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal CompletionPercentage { get; set; }

    public int DischargeStatus { get; set; }

    public bool IsBrushUsed { get; set; }

    public int Status { get; set; }

    public double? ActualStartTripLatitude { get; set; }

    public double? ActualStartTripLongitude { get; set; }

    [ForeignKey("TripId")]
    [InverseProperty("TripProcessingSummary")]
    public virtual Trip Trip { get; set; } = null!;
}
