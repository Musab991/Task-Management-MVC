using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class TripProcessingSummary
{
    public Guid Id { get; set; }

    public decimal TotalDistance { get; set; }

    public bool IsWaterUsed { get; set; }

    public double ExpectedCovarge { get; set; }

    public bool IsFinalized { get; set; }

    public double ActualCovarge { get; set; }

    public Guid TripId { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    public DateTime? ActualEndTrip { get; set; }

    public DateTime? ActualStartTrip { get; set; }

    public decimal CompletionPercentage { get; set; }

    public int DischargeStatus { get; set; }

    public bool IsBrushUsed { get; set; }

    public int Status { get; set; }

    public double? ActualStartTripLatitude { get; set; }

    public double? ActualStartTripLongitude { get; set; }

    public virtual Trip Trip { get; set; } = null!;
}
