using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.VehicleAvl;

[Table("tc_calendars")]
[MySqlCharSet("utf8mb3")]
[MySqlCollation("utf8mb3_general_ci")]
public partial class TcCalendar
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [StringLength(128)]
    public string Name { get; set; } = null!;

    [Column("data", TypeName = "mediumblob")]
    public byte[] Data { get; set; } = null!;

    [Column("attributes")]
    [StringLength(4000)]
    public string Attributes { get; set; } = null!;

    [InverseProperty("Calendar")]
    public virtual ICollection<TcDevice> TcDevices { get; set; } = new List<TcDevice>();

    [InverseProperty("Calendar")]
    public virtual ICollection<TcGeofence> TcGeofences { get; set; } = new List<TcGeofence>();

    [InverseProperty("Calendar")]
    public virtual ICollection<TcNotification> TcNotifications { get; set; } = new List<TcNotification>();

    [InverseProperty("Calendar")]
    public virtual ICollection<TcReport> TcReports { get; set; } = new List<TcReport>();

    [ForeignKey("Calendarid")]
    [InverseProperty("Calendars")]
    public virtual ICollection<TcUser> Users { get; set; } = new List<TcUser>();
}
