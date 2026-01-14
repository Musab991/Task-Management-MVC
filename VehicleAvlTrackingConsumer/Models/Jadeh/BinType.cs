using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh;

[Table("BinType")]
[Index("CreatedDate", Name = "IX_BinType_CreatedDate")]
[Index("DictionaryId", Name = "IX_BinType_DictionaryID")]
[Index("IsDeleted", Name = "IX_BinType_IsDeleted")]
[Index("TenantId", Name = "IX_BinType_TenantId")]
public partial class BinType
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(200)]
    public string? Name { get; set; }

    public double Weight { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    public int Type { get; set; }

    [Column("DictionaryID")]
    public int DictionaryId { get; set; }

    [InverseProperty("BinType")]
    public virtual ICollection<Bin> Bins { get; set; } = new List<Bin>();

    [ForeignKey("DictionaryId")]
    [InverseProperty("BinTypes")]
    public virtual Dictionary Dictionary { get; set; } = null!;
}
