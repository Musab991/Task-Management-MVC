using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class ReportSchedule
{
    public Guid Id { get; set; }

    public Guid ReportEngineId { get; set; }

    public int Frequency { get; set; }

    public string Timezone { get; set; } = null!;

    public TimeOnly RunAtLocalTime { get; set; }

    public DateTime? StartDateUtc { get; set; }

    public DateTime? EndDateUtc { get; set; }

    public bool IsEnabled { get; set; }

    public int OutputFormat { get; set; }

    public string Recipients { get; set; } = null!;

    public string? SubjectTemplate { get; set; }

    public string? BodyTemplate { get; set; }

    public Guid TenantId { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public string? Culture { get; set; }

    public int? DayOfMonth { get; set; }

    public virtual ReportEngine ReportEngine { get; set; } = null!;
}
