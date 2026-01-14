using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[Table("Lookup", Schema = "System")]
[Index("CategoryId", Name = "IX_Lookup_CategoryId")]
[Index("CreatedDate", Name = "IX_Lookup_CreatedDate")]
[Index("DictionaryId", Name = "IX_Lookup_DictionaryId")]
[Index("IsDeleted", Name = "IX_Lookup_IsDeleted")]
[Index("TenantId", Name = "IX_Lookup_TenantId")]
public partial class Lookup
{
    [Key]
    public int Id { get; set; }

    public int DictionaryId { get; set; }

    public int CategoryId { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public bool IsDeleted { get; set; }

    public Guid TenantId { get; set; }

    [InverseProperty("TypeLookup")]
    public virtual ICollection<Bin> Bins { get; set; } = new List<Bin>();

    [ForeignKey("CategoryId")]
    [InverseProperty("Lookups")]
    public virtual LookupCategory Category { get; set; } = null!;

    [ForeignKey("DictionaryId")]
    [InverseProperty("Lookups")]
    public virtual Dictionary Dictionary { get; set; } = null!;

    [InverseProperty("ManualLiftReasonLookup")]
    public virtual ICollection<TripDetailsProcessingSummary> TripDetailsProcessingSummaries { get; set; } = new List<TripDetailsProcessingSummary>();
}
