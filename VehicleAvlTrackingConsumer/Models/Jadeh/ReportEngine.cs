using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh;

[Index("CreatedDate", Name = "IX_ReportEngines_CreatedDate")]
[Index("IsDeleted", Name = "IX_ReportEngines_IsDeleted")]
[Index("TenantId", Name = "IX_ReportEngines_TenantId")]
public partial class ReportEngine
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(200)]
    public string Name { get; set; } = null!;

    [StringLength(200)]
    public string Description { get; set; } = null!;

    public int Dataset { get; set; }

    [StringLength(200)]
    public string? PrimaryDateField { get; set; }

    public int VisibilityScope { get; set; }

    public Guid OwnerUserId { get; set; }

    public Guid TenantId { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public Guid? DefaultSetByUserId { get; set; }

    public DateTime? DefaultSetAtUtc { get; set; }

    [StringLength(4000)]
    public string? HeaderTemplate { get; set; }

    [StringLength(4000)]
    public string? FooterTemplate { get; set; }

    [InverseProperty("ReportEngine")]
    public virtual ICollection<ReportAggregate> ReportAggregates { get; set; } = new List<ReportAggregate>();

    [InverseProperty("ReportEngine")]
    public virtual ICollection<ReportColumn> ReportColumns { get; set; } = new List<ReportColumn>();

    [InverseProperty("ReportEngine")]
    public virtual ICollection<ReportFilter> ReportFilters { get; set; } = new List<ReportFilter>();

    [InverseProperty("ReportEngine")]
    public virtual ICollection<ReportGroup> ReportGroups { get; set; } = new List<ReportGroup>();

    [InverseProperty("ReportEngine")]
    public virtual ICollection<ReportRunHistory> ReportRunHistories { get; set; } = new List<ReportRunHistory>();

    [InverseProperty("ReportEngine")]
    public virtual ICollection<ReportSchedule> ReportSchedules { get; set; } = new List<ReportSchedule>();

    [InverseProperty("ReportEngine")]
    public virtual ICollection<ReportSort> ReportSorts { get; set; } = new List<ReportSort>();
}
