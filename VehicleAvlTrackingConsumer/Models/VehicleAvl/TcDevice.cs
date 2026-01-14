using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.VehicleAvl;

[Table("tc_devices")]
[Index("Calendarid", Name = "fk_devices_calendarid")]
[Index("Groupid", Name = "fk_devices_groupid")]
[Index("Uniqueid", Name = "idx_devices_uniqueid", IsUnique = true)]
[MySqlCharSet("utf8mb3")]
[MySqlCollation("utf8mb3_general_ci")]
public partial class TcDevice
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [StringLength(128)]
    public string Name { get; set; } = null!;

    [Column("uniqueid")]
    [StringLength(128)]
    public string Uniqueid { get; set; } = null!;

    [Column("lastupdate", TypeName = "timestamp")]
    public DateTime? Lastupdate { get; set; }

    [Column("positionid")]
    public int? Positionid { get; set; }

    [Column("groupid")]
    public int? Groupid { get; set; }

    [Column("attributes")]
    [StringLength(4000)]
    public string? Attributes { get; set; }

    [Column("phone")]
    [StringLength(128)]
    public string? Phone { get; set; }

    [Column("model")]
    [StringLength(128)]
    public string? Model { get; set; }

    [Column("contact")]
    [StringLength(512)]
    public string? Contact { get; set; }

    [Column("category")]
    [StringLength(128)]
    public string? Category { get; set; }

    [Column("disabled", TypeName = "bit(1)")]
    public ulong? Disabled { get; set; }

    [Column("status")]
    [StringLength(8)]
    public string? Status { get; set; }

    [Column("expirationtime", TypeName = "timestamp")]
    public DateTime? Expirationtime { get; set; }

    [Column("motionstate", TypeName = "bit(1)")]
    public ulong? Motionstate { get; set; }

    [Column("motiontime", TypeName = "timestamp")]
    public DateTime? Motiontime { get; set; }

    [Column("motiondistance")]
    public double? Motiondistance { get; set; }

    [Column("overspeedstate", TypeName = "bit(1)")]
    public ulong? Overspeedstate { get; set; }

    [Column("overspeedtime", TypeName = "timestamp")]
    public DateTime? Overspeedtime { get; set; }

    [Column("overspeedgeofenceid")]
    public int? Overspeedgeofenceid { get; set; }

    [Column("motionstreak", TypeName = "bit(1)")]
    public ulong? Motionstreak { get; set; }

    [Column("calendarid")]
    public int? Calendarid { get; set; }

    [ForeignKey("Calendarid")]
    [InverseProperty("TcDevices")]
    public virtual TcCalendar? Calendar { get; set; }

    [ForeignKey("Groupid")]
    [InverseProperty("TcDevices")]
    public virtual TcGroup? Group { get; set; }

    [InverseProperty("Device")]
    public virtual ICollection<TcCommandsQueue> TcCommandsQueues { get; set; } = new List<TcCommandsQueue>();

    [ForeignKey("Deviceid")]
    [InverseProperty("Devices")]
    public virtual ICollection<TcAttribute> AttributesNavigation { get; set; } = new List<TcAttribute>();

    [ForeignKey("Deviceid")]
    [InverseProperty("Devices")]
    public virtual ICollection<TcCommand> Commands { get; set; } = new List<TcCommand>();

    [ForeignKey("Deviceid")]
    [InverseProperty("Devices")]
    public virtual ICollection<TcDriver> Drivers { get; set; } = new List<TcDriver>();

    [ForeignKey("Deviceid")]
    [InverseProperty("Devices")]
    public virtual ICollection<TcGeofence> Geofences { get; set; } = new List<TcGeofence>();

    [ForeignKey("Deviceid")]
    [InverseProperty("Devices")]
    public virtual ICollection<TcMaintenance> Maintenances { get; set; } = new List<TcMaintenance>();

    [ForeignKey("Deviceid")]
    [InverseProperty("Devices")]
    public virtual ICollection<TcNotification> Notifications { get; set; } = new List<TcNotification>();

    [ForeignKey("Deviceid")]
    [InverseProperty("Devices")]
    public virtual ICollection<TcOrder> Orders { get; set; } = new List<TcOrder>();

    [ForeignKey("Deviceid")]
    [InverseProperty("Devices")]
    public virtual ICollection<TcReport> Reports { get; set; } = new List<TcReport>();

    [ForeignKey("Deviceid")]
    [InverseProperty("Devices")]
    public virtual ICollection<TcUser> Users { get; set; } = new List<TcUser>();
}
