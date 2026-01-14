using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.VehicleAvl;

[Table("tc_users")]
[Index("Email", Name = "email", IsUnique = true)]
[Index("Login", Name = "idx_users_login")]
[MySqlCharSet("utf8mb3")]
[MySqlCollation("utf8mb3_general_ci")]
public partial class TcUser
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [StringLength(128)]
    public string Name { get; set; } = null!;

    [Column("email")]
    [StringLength(128)]
    public string Email { get; set; } = null!;

    [Column("hashedpassword")]
    [StringLength(128)]
    public string? Hashedpassword { get; set; }

    [Column("salt")]
    [StringLength(128)]
    public string? Salt { get; set; }

    [Column("readonly", TypeName = "bit(1)")]
    public ulong Readonly { get; set; }

    [Column("administrator", TypeName = "bit(1)")]
    public ulong? Administrator { get; set; }

    [Column("map")]
    [StringLength(128)]
    public string? Map { get; set; }

    [Column("latitude")]
    public double Latitude { get; set; }

    [Column("longitude")]
    public double Longitude { get; set; }

    [Column("zoom")]
    public int Zoom { get; set; }

    [Column("attributes")]
    [StringLength(4000)]
    public string? Attributes { get; set; }

    [Column("coordinateformat")]
    [StringLength(128)]
    public string? Coordinateformat { get; set; }

    [Column("disabled", TypeName = "bit(1)")]
    public ulong? Disabled { get; set; }

    [Column("expirationtime", TypeName = "timestamp")]
    public DateTime? Expirationtime { get; set; }

    [Column("devicelimit")]
    public int? Devicelimit { get; set; }

    [Column("userlimit")]
    public int? Userlimit { get; set; }

    [Column("devicereadonly", TypeName = "bit(1)")]
    public ulong? Devicereadonly { get; set; }

    [Column("phone")]
    [StringLength(128)]
    public string? Phone { get; set; }

    [Column("limitcommands", TypeName = "bit(1)")]
    public ulong? Limitcommands { get; set; }

    [Column("login")]
    [StringLength(128)]
    public string? Login { get; set; }

    [Column("poilayer")]
    [StringLength(512)]
    public string? Poilayer { get; set; }

    [Column("disablereports", TypeName = "bit(1)")]
    public ulong? Disablereports { get; set; }

    [Column("fixedemail", TypeName = "bit(1)")]
    public ulong? Fixedemail { get; set; }

    [Column("totpkey")]
    [StringLength(64)]
    public string? Totpkey { get; set; }

    [Column("TEMPORARY")]
    public bool? Temporary { get; set; }

    [ForeignKey("Userid")]
    [InverseProperty("Users")]
    public virtual ICollection<TcAttribute> AttributesNavigation { get; set; } = new List<TcAttribute>();

    [ForeignKey("Userid")]
    [InverseProperty("Users")]
    public virtual ICollection<TcCalendar> Calendars { get; set; } = new List<TcCalendar>();

    [ForeignKey("Userid")]
    [InverseProperty("Users")]
    public virtual ICollection<TcCommand> Commands { get; set; } = new List<TcCommand>();

    [ForeignKey("Userid")]
    [InverseProperty("Users")]
    public virtual ICollection<TcDevice> Devices { get; set; } = new List<TcDevice>();

    [ForeignKey("Userid")]
    [InverseProperty("Users")]
    public virtual ICollection<TcDriver> Drivers { get; set; } = new List<TcDriver>();

    [ForeignKey("Userid")]
    [InverseProperty("Users")]
    public virtual ICollection<TcGeofence> Geofences { get; set; } = new List<TcGeofence>();

    [ForeignKey("Userid")]
    [InverseProperty("Users")]
    public virtual ICollection<TcGroup> Groups { get; set; } = new List<TcGroup>();

    [ForeignKey("Userid")]
    [InverseProperty("Users")]
    public virtual ICollection<TcMaintenance> Maintenances { get; set; } = new List<TcMaintenance>();

    [ForeignKey("Userid")]
    [InverseProperty("Users")]
    public virtual ICollection<TcUser> Managedusers { get; set; } = new List<TcUser>();

    [ForeignKey("Userid")]
    [InverseProperty("Users")]
    public virtual ICollection<TcNotification> Notifications { get; set; } = new List<TcNotification>();

    [ForeignKey("Userid")]
    [InverseProperty("Users")]
    public virtual ICollection<TcOrder> Orders { get; set; } = new List<TcOrder>();

    [ForeignKey("Userid")]
    [InverseProperty("Users")]
    public virtual ICollection<TcReport> Reports { get; set; } = new List<TcReport>();

    [ForeignKey("Manageduserid")]
    [InverseProperty("Managedusers")]
    public virtual ICollection<TcUser> Users { get; set; } = new List<TcUser>();
}
