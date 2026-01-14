using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.VehicleAvl;

[Table("tc_geofences")]
[Index("Calendarid", Name = "fk_geofence_calendar_calendarid")]
[MySqlCharSet("utf8mb3")]
[MySqlCollation("utf8mb3_general_ci")]
public partial class TcGeofence
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [StringLength(128)]
    public string Name { get; set; } = null!;

    [Column("description")]
    [StringLength(128)]
    public string? Description { get; set; }

    [Column("area")]
    [StringLength(4096)]
    public string Area { get; set; } = null!;

    [Column("attributes")]
    [StringLength(4000)]
    public string? Attributes { get; set; }

    [Column("calendarid")]
    public int? Calendarid { get; set; }

    [ForeignKey("Calendarid")]
    [InverseProperty("TcGeofences")]
    public virtual TcCalendar? Calendar { get; set; }

    [ForeignKey("Geofenceid")]
    [InverseProperty("Geofences")]
    public virtual ICollection<TcDevice> Devices { get; set; } = new List<TcDevice>();

    [ForeignKey("Geofenceid")]
    [InverseProperty("Geofences")]
    public virtual ICollection<TcGroup> Groups { get; set; } = new List<TcGroup>();

    [ForeignKey("Geofenceid")]
    [InverseProperty("Geofences")]
    public virtual ICollection<TcUser> Users { get; set; } = new List<TcUser>();
}
