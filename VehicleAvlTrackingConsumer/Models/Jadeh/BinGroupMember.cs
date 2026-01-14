using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh;

[Table("BinGroupMember")]
[Index("BinGroupId", Name = "IX_BinGroupMember_BinGroupId")]
[Index("BinId", Name = "IX_BinGroupMember_BinId")]
public partial class BinGroupMember
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(200)]
    public string? BinTag { get; set; }

    public Guid BinGroupId { get; set; }

    public Guid BinId { get; set; }

    [ForeignKey("BinId")]
    [InverseProperty("BinGroupMembers")]
    public virtual Bin Bin { get; set; } = null!;

    [ForeignKey("BinGroupId")]
    [InverseProperty("BinGroupMembers")]
    public virtual BinGroup BinGroup { get; set; } = null!;
}
