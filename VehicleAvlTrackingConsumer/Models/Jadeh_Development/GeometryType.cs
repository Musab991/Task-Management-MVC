using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[Table("GeometryType")]
[Index("CreatedDate", Name = "IX_GeometryType_CreatedDate")]
[Index("IsDeleted", Name = "IX_GeometryType_IsDeleted")]
[Index("TenantId", Name = "IX_GeometryType_TenantId")]
public partial class GeometryType
{
    [Key]
    public int Id { get; set; }

    public int Type { get; set; }

    [StringLength(200)]
    public string? Description { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public bool IsDeleted { get; set; }

    public Guid TenantId { get; set; }

    [InverseProperty("GeometryType")]
    public virtual ICollection<ServiceGeometryType> ServiceGeometryTypes { get; set; } = new List<ServiceGeometryType>();
}
