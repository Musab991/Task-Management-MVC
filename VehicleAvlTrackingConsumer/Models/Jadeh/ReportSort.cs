using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh;

[Index("CreatedDate", Name = "IX_ReportSorts_CreatedDate")]
[Index("IsDeleted", Name = "IX_ReportSorts_IsDeleted")]
[Index("ReportEngineId", Name = "IX_ReportSorts_ReportEngineId")]
[Index("TenantId", Name = "IX_ReportSorts_TenantId")]
public partial class ReportSort
{
    [Key]
    public Guid Id { get; set; }

    public Guid ReportEngineId { get; set; }

    [StringLength(200)]
    public string FieldKey { get; set; } = null!;

    public bool IsDescending { get; set; }

    public int SortOrder { get; set; }

    public Guid TenantId { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    [ForeignKey("ReportEngineId")]
    [InverseProperty("ReportSorts")]
    public virtual ReportEngine ReportEngine { get; set; } = null!;
}
