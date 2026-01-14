using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh;

[PrimaryKey("ServiceId", "GeometryTypeId")]
[Table("ServiceGeometryType")]
[Index("CreatedDate", Name = "IX_ServiceGeometryType_CreatedDate")]
[Index("GeometryTypeId", Name = "IX_ServiceGeometryType_GeometryTypeId")]
[Index("IsDeleted", Name = "IX_ServiceGeometryType_IsDeleted")]
[Index("TenantId", Name = "IX_ServiceGeometryType_TenantId")]
public partial class ServiceGeometryType
{
    [Key]
    public Guid ServiceId { get; set; }

    [Key]
    public int GeometryTypeId { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    [ForeignKey("GeometryTypeId")]
    [InverseProperty("ServiceGeometryTypes")]
    public virtual GeometryType GeometryType { get; set; } = null!;

    [ForeignKey("ServiceId")]
    [InverseProperty("ServiceGeometryTypes")]
    public virtual Service Service { get; set; } = null!;
}
