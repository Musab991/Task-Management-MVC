using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[Index("CreatedDate", Name = "IX_ReportSchedules_CreatedDate")]
[Index("IsDeleted", Name = "IX_ReportSchedules_IsDeleted")]
[Index("ReportEngineId", Name = "IX_ReportSchedules_ReportEngineId")]
[Index("TenantId", Name = "IX_ReportSchedules_TenantId")]
public partial class ReportSchedule
{
    [Key]
    public Guid Id { get; set; }

    public Guid ReportEngineId { get; set; }

    public int Frequency { get; set; }

    [StringLength(200)]
    public string Timezone { get; set; } = null!;

    public TimeOnly RunAtLocalTime { get; set; }

    public DateTime? StartDateUtc { get; set; }

    public DateTime? EndDateUtc { get; set; }

    public bool IsEnabled { get; set; }

    public int OutputFormat { get; set; }

    [StringLength(200)]
    public string Recipients { get; set; } = null!;

    [StringLength(200)]
    public string? SubjectTemplate { get; set; }

    [StringLength(200)]
    public string? BodyTemplate { get; set; }

    public Guid TenantId { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    [StringLength(10)]
    public string? Culture { get; set; }

    public int? DayOfMonth { get; set; }

    [ForeignKey("ReportEngineId")]
    [InverseProperty("ReportSchedules")]
    public virtual ReportEngine ReportEngine { get; set; } = null!;
}
