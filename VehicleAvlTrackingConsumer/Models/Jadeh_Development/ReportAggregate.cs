using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[Index("CreatedDate", Name = "IX_ReportAggregates_CreatedDate")]
[Index("IsDeleted", Name = "IX_ReportAggregates_IsDeleted")]
[Index("ReportEngineId", Name = "IX_ReportAggregates_ReportEngineId")]
[Index("TenantId", Name = "IX_ReportAggregates_TenantId")]
public partial class ReportAggregate
{
    [Key]
    public Guid Id { get; set; }

    public Guid ReportEngineId { get; set; }

    [StringLength(200)]
    public string FieldKey { get; set; } = null!;

    [StringLength(200)]
    public string Function { get; set; } = null!;

    public Guid TenantId { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    [ForeignKey("ReportEngineId")]
    [InverseProperty("ReportAggregates")]
    public virtual ReportEngine ReportEngine { get; set; } = null!;
}
