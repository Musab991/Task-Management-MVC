using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[Table("LookupCategory", Schema = "System")]
[Index("CreatedDate", Name = "IX_LookupCategory_CreatedDate")]
[Index("IsDeleted", Name = "IX_LookupCategory_IsDeleted")]
[Index("TenantId", Name = "IX_LookupCategory_TenantId")]
public partial class LookupCategory
{
    [Key]
    public int Id { get; set; }

    [StringLength(200)]
    public string? Description { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public bool IsDeleted { get; set; }

    public Guid TenantId { get; set; }

    [InverseProperty("Category")]
    public virtual ICollection<Lookup> Lookups { get; set; } = new List<Lookup>();
}
