using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.VehicleAvl;

[Table("tc_commands")]
[MySqlCharSet("utf8mb3")]
[MySqlCollation("utf8mb3_general_ci")]
public partial class TcCommand
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("description")]
    [StringLength(4000)]
    public string Description { get; set; } = null!;

    [Column("type")]
    [StringLength(128)]
    public string Type { get; set; } = null!;

    [Column("textchannel", TypeName = "bit(1)")]
    public ulong Textchannel { get; set; }

    [Column("attributes")]
    [StringLength(4000)]
    public string Attributes { get; set; } = null!;

    [InverseProperty("Command")]
    public virtual ICollection<TcNotification> TcNotifications { get; set; } = new List<TcNotification>();

    [ForeignKey("Commandid")]
    [InverseProperty("Commands")]
    public virtual ICollection<TcDevice> Devices { get; set; } = new List<TcDevice>();

    [ForeignKey("Commandid")]
    [InverseProperty("Commands")]
    public virtual ICollection<TcGroup> Groups { get; set; } = new List<TcGroup>();

    [ForeignKey("Commandid")]
    [InverseProperty("Commands")]
    public virtual ICollection<TcUser> Users { get; set; } = new List<TcUser>();
}
