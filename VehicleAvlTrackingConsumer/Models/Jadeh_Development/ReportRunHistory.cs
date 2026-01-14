using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[Index("CreatedDate", Name = "IX_ReportRunHistories_CreatedDate")]
[Index("IsDeleted", Name = "IX_ReportRunHistories_IsDeleted")]
[Index("ReportEngineId", Name = "IX_ReportRunHistories_ReportEngineId")]
[Index("TenantId", Name = "IX_ReportRunHistories_TenantId")]
public partial class ReportRunHistory
{
    [Key]
    public Guid Id { get; set; }

    public Guid ReportEngineId { get; set; }

    public DateTime StartedAtUtc { get; set; }

    public DateTime? EndedAtUtc { get; set; }

    public bool IsSuccess { get; set; }

    public int RowsReturned { get; set; }

    [StringLength(200)]
    public string? ErrorMessage { get; set; }

    [StringLength(200)]
    public string? ArtifactPath { get; set; }

    public Guid TenantId { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    [ForeignKey("ReportEngineId")]
    [InverseProperty("ReportRunHistories")]
    public virtual ReportEngine ReportEngine { get; set; } = null!;
}
