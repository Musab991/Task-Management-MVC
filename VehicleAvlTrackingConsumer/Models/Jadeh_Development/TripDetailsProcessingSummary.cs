using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[Table("TripDetailsProcessingSummary")]
[Index("ManualLiftReasonLookupId", Name = "IX_TripDetailsProcessingSummary_ManualLiftReasonLookupId")]
[Index("TenantId", Name = "IX_TripDetailsProcessingSummary_TenantId")]
[Index("TripDetailsId", Name = "IX_TripDetailsProcessingSummary_TripDetailsId", IsUnique = true)]
public partial class TripDetailsProcessingSummary
{
    [Key]
    public Guid Id { get; set; }

    public DateTime? LastCompletion { get; set; }

    public DateTime? ArrivalTime { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal TotalDistance { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal WaterUsedLiters { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal SweptAreaSquareMeters { get; set; }

    public Guid TripDetailsId { get; set; }

    public DateTime? CompletionTime { get; set; }

    public Guid TenantId { get; set; }

    public double BinLatitude { get; set; }

    public double BinLongitude { get; set; }

    public int BinStatusId { get; set; }

    public double BinWeight { get; set; }

    [StringLength(200)]
    public string? CompilationReason { get; set; }

    public int CompletionOrder { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal CompletionPercentage { get; set; }

    public int NumberOfLefts { get; set; }

    public int NumberOfRotation { get; set; }

    public double TotalOfWasteCollectedFromContainer { get; set; }

    public double WasteActualWeight { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public double TotalGpsDistanceCovered { get; set; }

    [StringLength(200)]
    public string? Description { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    public int? CompletionType { get; set; }

    public double? TotalBrushDistanceCovered { get; set; }

    public double? TotalWaterDistanceCovered { get; set; }

    public bool IsSwept { get; set; }

    public int? ManualLiftReasonLookupId { get; set; }

    public long TrackingDeviceNumber { get; set; }

    public Guid? VehicleId { get; set; }

    [ForeignKey("ManualLiftReasonLookupId")]
    [InverseProperty("TripDetailsProcessingSummaries")]
    public virtual Lookup? ManualLiftReasonLookup { get; set; }

    [ForeignKey("TripDetailsId")]
    [InverseProperty("TripDetailsProcessingSummary")]
    public virtual TripDetail TripDetails { get; set; } = null!;
}
