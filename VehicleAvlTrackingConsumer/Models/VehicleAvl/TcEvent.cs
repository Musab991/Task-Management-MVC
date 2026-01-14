using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.VehicleAvl;

[Table("tc_events")]
[Index("Deviceid", "Eventtime", Name = "event_deviceid_servertime")]
[MySqlCharSet("utf8mb3")]
[MySqlCollation("utf8mb3_general_ci")]
public partial class TcEvent
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("type")]
    [StringLength(128)]
    public string Type { get; set; } = null!;

    [Column("eventtime", TypeName = "timestamp")]
    public DateTime? Eventtime { get; set; }

    [Column("deviceid")]
    public int? Deviceid { get; set; }

    [Column("positionid")]
    public int? Positionid { get; set; }

    [Column("geofenceid")]
    public int? Geofenceid { get; set; }

    [Column("attributes")]
    [StringLength(4000)]
    public string? Attributes { get; set; }

    [Column("maintenanceid")]
    public int? Maintenanceid { get; set; }
}
