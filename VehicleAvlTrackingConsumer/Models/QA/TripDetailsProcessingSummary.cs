using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class TripDetailsProcessingSummary
{
    public Guid Id { get; set; }

    public DateTime? LastCompletion { get; set; }

    public DateTime? ArrivalTime { get; set; }

    public decimal TotalDistance { get; set; }

    public decimal WaterUsedLiters { get; set; }

    public decimal SweptAreaSquareMeters { get; set; }

    public Guid TripDetailsId { get; set; }

    public DateTime? CompletionTime { get; set; }

    public Guid TenantId { get; set; }

    public double BinLatitude { get; set; }

    public double BinLongitude { get; set; }

    public int BinStatusId { get; set; }

    public double BinWeight { get; set; }

    public string? CompilationReason { get; set; }

    public int CompletionOrder { get; set; }

    public decimal CompletionPercentage { get; set; }

    public int NumberOfLefts { get; set; }

    public int NumberOfRotation { get; set; }

    public double TotalOfWasteCollectedFromContainer { get; set; }

    public double WasteActualWeight { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public double? TotalGpsDistanceCovered { get; set; }

    public string? Description { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CompletionType { get; set; }

    public double? TotalBrushDistanceCovered { get; set; }

    public double? TotalWaterDistanceCovered { get; set; }

    public bool IsSwept { get; set; }

    public int? ManualLiftReasonLookupId { get; set; }

    public long TrackingDeviceNumber { get; set; }

    public Guid? VehicleId { get; set; }

    public int? StatusLookupId { get; set; }

    public virtual Lookup? ManualLiftReasonLookup { get; set; }

    public virtual Lookup? StatusLookup { get; set; }

    public virtual TripDetail TripDetails { get; set; } = null!;
}
