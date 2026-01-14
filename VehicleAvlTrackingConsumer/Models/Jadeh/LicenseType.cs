using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh;

[Table("LicenseType")]
[Index("CreatedDate", Name = "IX_LicenseType_CreatedDate")]
[Index("IsDeleted", Name = "IX_LicenseType_IsDeleted")]
[Index("TenantId", Name = "IX_LicenseType_TenantId")]
public partial class LicenseType
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(100)]
    public string Name { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public bool IsDeleted { get; set; }

    public Guid TenantId { get; set; }

    public int Type { get; set; }

    [InverseProperty("LicenseType")]
    public virtual ICollection<Crew> Crews { get; set; } = new List<Crew>();

    [InverseProperty("Entity")]
    public virtual ICollection<LicenseTypeLocalization> LicenseTypeLocalizations { get; set; } = new List<LicenseTypeLocalization>();
}
