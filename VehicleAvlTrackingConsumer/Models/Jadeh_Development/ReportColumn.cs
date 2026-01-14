using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[Index("CreatedDate", Name = "IX_ReportColumns_CreatedDate")]
[Index("IsDeleted", Name = "IX_ReportColumns_IsDeleted")]
[Index("ReportEngineId", Name = "IX_ReportColumns_ReportEngineId")]
[Index("TenantId", Name = "IX_ReportColumns_TenantId")]
public partial class ReportColumn
{
    [Key]
    public Guid Id { get; set; }

    public Guid ReportEngineId { get; set; }

    [StringLength(200)]
    public string FieldKey { get; set; } = null!;

    [StringLength(200)]
    public string Label { get; set; } = null!;

    public int DisplayOrder { get; set; }

    public int? WidthPx { get; set; }

    [StringLength(200)]
    public string? Format { get; set; }

    public bool IsComputed { get; set; }

    [StringLength(200)]
    public string? Expression { get; set; }

    public Guid TenantId { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    [ForeignKey("ReportEngineId")]
    [InverseProperty("ReportColumns")]
    public virtual ReportEngine ReportEngine { get; set; } = null!;
}
