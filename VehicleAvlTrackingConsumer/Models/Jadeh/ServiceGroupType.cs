using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh;

[Index("CreatedDate", Name = "IX_ServiceGroupTypes_CreatedDate")]
[Index("DictionaryId", Name = "IX_ServiceGroupTypes_DictionaryID")]
[Index("IsDeleted", Name = "IX_ServiceGroupTypes_IsDeleted")]
[Index("TenantId", Name = "IX_ServiceGroupTypes_TenantId")]
public partial class ServiceGroupType
{
    [Key]
    public Guid Id { get; set; }

    public int Type { get; set; }

    public DateTime CreatedDate { get; set; }

    [Column("DictionaryID")]
    public int DictionaryId { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    public bool IsDeleted { get; set; }

    [ForeignKey("DictionaryId")]
    [InverseProperty("ServiceGroupTypes")]
    public virtual Dictionary Dictionary { get; set; } = null!;

    [InverseProperty("ServiceGroupType")]
    public virtual ICollection<ServiceGroupServiceGroupType> ServiceGroupServiceGroupTypes { get; set; } = new List<ServiceGroupServiceGroupType>();

    [InverseProperty("ServiceGroupType")]
    public virtual ICollection<ServiceGroup> ServiceGroups { get; set; } = new List<ServiceGroup>();
}
