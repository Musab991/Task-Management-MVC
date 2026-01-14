using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class SpInsertDebugLog
{
    public long LogId { get; set; }

    public string? ProcedureName { get; set; }

    public string? StepName { get; set; }

    public int? ErrorNumber { get; set; }

    public int? ErrorSeverity { get; set; }

    public int? ErrorState { get; set; }

    public int? ErrorLine { get; set; }

    public string? ErrorMessage { get; set; }

    public string? AdditionalInfo { get; set; }

    public DateTime CreatedDate { get; set; }
}
