using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[Table("ZoneType")]
[Index("CreatedDate", Name = "IX_ZoneType_CreatedDate")]
[Index("IsDeleted", Name = "IX_ZoneType_IsDeleted")]
[Index("TenantId", Name = "IX_ZoneType_TenantId")]
public partial class ZoneType
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(200)]
    public string? Color { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    public bool IsDeleted { get; set; }

    [InverseProperty("Entity")]
    public virtual ICollection<ZoneTypeLocalization> ZoneTypeLocalizations { get; set; } = new List<ZoneTypeLocalization>();

    [InverseProperty("ZoneType")]
    public virtual ICollection<Zone> Zones { get; set; } = new List<Zone>();
}
