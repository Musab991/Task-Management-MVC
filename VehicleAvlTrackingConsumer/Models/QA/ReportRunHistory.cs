using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class ReportRunHistory
{
    public Guid Id { get; set; }

    public Guid ReportEngineId { get; set; }

    public DateTime StartedAtUtc { get; set; }

    public DateTime? EndedAtUtc { get; set; }

    public bool IsSuccess { get; set; }

    public int RowsReturned { get; set; }

    public string? ErrorMessage { get; set; }

    public string? ArtifactPath { get; set; }

    public Guid TenantId { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public virtual ReportEngine ReportEngine { get; set; } = null!;
}
