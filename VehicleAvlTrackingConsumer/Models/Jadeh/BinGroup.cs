using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh;

[Table("BinGroup")]
[Index("CreatedDate", Name = "IX_BinGroup_CreatedDate")]
[Index("TenantId", Name = "IX_BinGroup_TenantId")]
public partial class BinGroup
{
    [Key]
    public Guid Id { get; set; }

    public Guid TenantId { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    [InverseProperty("BinGroup")]
    public virtual ICollection<BinGroupMember> BinGroupMembers { get; set; } = new List<BinGroupMember>();
}
