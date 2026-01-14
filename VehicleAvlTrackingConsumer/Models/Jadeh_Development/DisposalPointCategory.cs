using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[Table("DisposalPointCategory")]
[Index("CreatedDate", Name = "IX_DisposalPointCategory_CreatedDate")]
[Index("DictionaryId", Name = "IX_DisposalPointCategory_DictionaryId")]
[Index("IsDeleted", Name = "IX_DisposalPointCategory_IsDeleted")]
[Index("TenantId", Name = "IX_DisposalPointCategory_TenantId")]
public partial class DisposalPointCategory
{
    [Key]
    public int Id { get; set; }

    public int? DictionaryId { get; set; }

    [StringLength(200)]
    public string? ColorHex { get; set; }

    public int Type { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    [ForeignKey("DictionaryId")]
    [InverseProperty("DisposalPointCategories")]
    public virtual Dictionary? Dictionary { get; set; }

    [InverseProperty("Category")]
    public virtual ICollection<DisposalPoint> DisposalPoints { get; set; } = new List<DisposalPoint>();
}
