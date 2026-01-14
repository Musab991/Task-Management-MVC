using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[Index("CreatedDate", Name = "IX_Zones_CreatedDate")]
[Index("IsDeleted", Name = "IX_Zones_IsDeleted")]
[Index("TenantId", Name = "IX_Zones_TenantId")]
[Index("ZoneTypeId", Name = "IX_Zones_ZoneTypeId")]
public partial class Zone
{
    [Key]
    public Guid Id { get; set; }

    public string? GeometryJson { get; set; }

    public Guid ZoneTypeId { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    public bool IsDeleted { get; set; }

    public TimeOnly AllowedAccessTimeEnd { get; set; }

    public TimeOnly AllowedAccessTimeStart { get; set; }

    public DateTime? LastAccessTime { get; set; }

    public string? GeoJson { get; set; }

    [ForeignKey("ZoneTypeId")]
    [InverseProperty("Zones")]
    public virtual ZoneType ZoneType { get; set; } = null!;

    [InverseProperty("Entity")]
    public virtual ICollection<ZonesLocalization> ZonesLocalizations { get; set; } = new List<ZonesLocalization>();

    [InverseProperty("Zone")]
    public virtual ICollection<ZonesVehicle> ZonesVehicles { get; set; } = new List<ZonesVehicle>();
}
