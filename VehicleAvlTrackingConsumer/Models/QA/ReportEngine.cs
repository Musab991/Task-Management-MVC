using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class ReportEngine
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int Dataset { get; set; }

    public string? PrimaryDateField { get; set; }

    public int VisibilityScope { get; set; }

    public Guid OwnerUserId { get; set; }

    public Guid TenantId { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public Guid? DefaultSetByUserId { get; set; }

    public DateTime? DefaultSetAtUtc { get; set; }

    public string? HeaderTemplate { get; set; }

    public string? FooterTemplate { get; set; }

    public virtual ICollection<ReportAggregate> ReportAggregates { get; set; } = new List<ReportAggregate>();

    public virtual ICollection<ReportColumn> ReportColumns { get; set; } = new List<ReportColumn>();

    public virtual ICollection<ReportFilter> ReportFilters { get; set; } = new List<ReportFilter>();

    public virtual ICollection<ReportGroup> ReportGroups { get; set; } = new List<ReportGroup>();

    public virtual ICollection<ReportRunHistory> ReportRunHistories { get; set; } = new List<ReportRunHistory>();

    public virtual ICollection<ReportSchedule> ReportSchedules { get; set; } = new List<ReportSchedule>();

    public virtual ICollection<ReportSort> ReportSorts { get; set; } = new List<ReportSort>();
}
