using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[Index("CreatedDate", Name = "IX_ReportFilters_CreatedDate")]
[Index("IsDeleted", Name = "IX_ReportFilters_IsDeleted")]
[Index("ReportEngineId", Name = "IX_ReportFilters_ReportEngineId")]
[Index("TenantId", Name = "IX_ReportFilters_TenantId")]
public partial class ReportFilter
{
    [Key]
    public Guid Id { get; set; }

    public Guid ReportEngineId { get; set; }

    [StringLength(200)]
    public string FieldKey { get; set; } = null!;

    public int Operator { get; set; }

    [StringLength(200)]
    public string? Value1 { get; set; }

    [StringLength(200)]
    public string? Value2 { get; set; }

    public Guid TenantId { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    [ForeignKey("ReportEngineId")]
    [InverseProperty("ReportFilters")]
    public virtual ReportEngine ReportEngine { get; set; } = null!;
}
