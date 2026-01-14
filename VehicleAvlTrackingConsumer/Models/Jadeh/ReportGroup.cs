using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh;

[Index("CreatedDate", Name = "IX_ReportGroups_CreatedDate")]
[Index("IsDeleted", Name = "IX_ReportGroups_IsDeleted")]
[Index("ReportEngineId", Name = "IX_ReportGroups_ReportEngineId")]
[Index("TenantId", Name = "IX_ReportGroups_TenantId")]
public partial class ReportGroup
{
    [Key]
    public Guid Id { get; set; }

    public Guid ReportEngineId { get; set; }

    [StringLength(200)]
    public string FieldKey { get; set; } = null!;

    public int GroupOrder { get; set; }

    public Guid TenantId { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    [ForeignKey("ReportEngineId")]
    [InverseProperty("ReportGroups")]
    public virtual ReportEngine ReportEngine { get; set; } = null!;
}
