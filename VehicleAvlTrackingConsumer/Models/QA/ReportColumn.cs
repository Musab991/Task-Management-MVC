using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class ReportColumn
{
    public Guid Id { get; set; }

    public Guid ReportEngineId { get; set; }

    public string FieldKey { get; set; } = null!;

    public string Label { get; set; } = null!;

    public int DisplayOrder { get; set; }

    public int? WidthPx { get; set; }

    public string? Format { get; set; }

    public bool IsComputed { get; set; }

    public string? Expression { get; set; }

    public Guid TenantId { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public virtual ReportEngine ReportEngine { get; set; } = null!;
}
