using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.VehicleAvl;

[Table("tc_groups")]
[Index("Groupid", Name = "fk_groups_groupid")]
[MySqlCharSet("utf8mb3")]
[MySqlCollation("utf8mb3_general_ci")]
public partial class TcGroup
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [StringLength(128)]
    public string Name { get; set; } = null!;

    [Column("groupid")]
    public int? Groupid { get; set; }

    [Column("attributes")]
    [StringLength(4000)]
    public string? Attributes { get; set; }

    [ForeignKey("Groupid")]
    [InverseProperty("InverseGroup")]
    public virtual TcGroup? Group { get; set; }

    [InverseProperty("Group")]
    public virtual ICollection<TcGroup> InverseGroup { get; set; } = new List<TcGroup>();

    [InverseProperty("Group")]
    public virtual ICollection<TcDevice> TcDevices { get; set; } = new List<TcDevice>();

    [ForeignKey("Groupid")]
    [InverseProperty("Groups")]
    public virtual ICollection<TcAttribute> AttributesNavigation { get; set; } = new List<TcAttribute>();

    [ForeignKey("Groupid")]
    [InverseProperty("Groups")]
    public virtual ICollection<TcCommand> Commands { get; set; } = new List<TcCommand>();

    [ForeignKey("Groupid")]
    [InverseProperty("Groups")]
    public virtual ICollection<TcDriver> Drivers { get; set; } = new List<TcDriver>();

    [ForeignKey("Groupid")]
    [InverseProperty("Groups")]
    public virtual ICollection<TcGeofence> Geofences { get; set; } = new List<TcGeofence>();

    [ForeignKey("Groupid")]
    [InverseProperty("Groups")]
    public virtual ICollection<TcMaintenance> Maintenances { get; set; } = new List<TcMaintenance>();

    [ForeignKey("Groupid")]
    [InverseProperty("Groups")]
    public virtual ICollection<TcNotification> Notifications { get; set; } = new List<TcNotification>();

    [ForeignKey("Groupid")]
    [InverseProperty("Groups")]
    public virtual ICollection<TcOrder> Orders { get; set; } = new List<TcOrder>();

    [ForeignKey("Groupid")]
    [InverseProperty("Groups")]
    public virtual ICollection<TcReport> Reports { get; set; } = new List<TcReport>();

    [ForeignKey("Groupid")]
    [InverseProperty("Groups")]
    public virtual ICollection<TcUser> Users { get; set; } = new List<TcUser>();
}
