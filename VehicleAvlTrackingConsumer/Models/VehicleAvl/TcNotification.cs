using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.VehicleAvl;

[Table("tc_notifications")]
[Index("Calendarid", Name = "fk_notification_calendar_calendarid")]
[Index("Commandid", Name = "fk_notifications_commandid")]
[MySqlCharSet("utf8mb3")]
[MySqlCollation("utf8mb3_general_ci")]
public partial class TcNotification
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("type")]
    [StringLength(128)]
    public string Type { get; set; } = null!;

    [Column("attributes")]
    [StringLength(4000)]
    public string? Attributes { get; set; }

    [Column("always", TypeName = "bit(1)")]
    public ulong Always { get; set; }

    [Column("calendarid")]
    public int? Calendarid { get; set; }

    [Column("notificators")]
    [StringLength(128)]
    public string? Notificators { get; set; }

    [Column("commandid")]
    public int? Commandid { get; set; }

    [Column("description")]
    [StringLength(4000)]
    public string? Description { get; set; }

    [ForeignKey("Calendarid")]
    [InverseProperty("TcNotifications")]
    public virtual TcCalendar? Calendar { get; set; }

    [ForeignKey("Commandid")]
    [InverseProperty("TcNotifications")]
    public virtual TcCommand? Command { get; set; }

    [ForeignKey("Notificationid")]
    [InverseProperty("Notifications")]
    public virtual ICollection<TcDevice> Devices { get; set; } = new List<TcDevice>();

    [ForeignKey("Notificationid")]
    [InverseProperty("Notifications")]
    public virtual ICollection<TcGroup> Groups { get; set; } = new List<TcGroup>();

    [ForeignKey("Notificationid")]
    [InverseProperty("Notifications")]
    public virtual ICollection<TcUser> Users { get; set; } = new List<TcUser>();
}
