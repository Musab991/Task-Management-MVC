using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.VehicleAvl;

[Table("tc_servers")]
[MySqlCharSet("utf8mb3")]
[MySqlCollation("utf8mb3_general_ci")]
public partial class TcServer
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("registration", TypeName = "bit(1)")]
    public ulong Registration { get; set; }

    [Column("latitude")]
    public double Latitude { get; set; }

    [Column("longitude")]
    public double Longitude { get; set; }

    [Column("zoom")]
    public int Zoom { get; set; }

    [Column("map")]
    [StringLength(128)]
    public string? Map { get; set; }

    [Column("bingkey")]
    [StringLength(128)]
    public string? Bingkey { get; set; }

    [Column("mapurl")]
    [StringLength(512)]
    public string? Mapurl { get; set; }

    [Column("readonly", TypeName = "bit(1)")]
    public ulong Readonly { get; set; }

    [Column("attributes")]
    [StringLength(4000)]
    public string? Attributes { get; set; }

    [Column("forcesettings", TypeName = "bit(1)")]
    public ulong Forcesettings { get; set; }

    [Column("coordinateformat")]
    [StringLength(128)]
    public string? Coordinateformat { get; set; }

    [Column("devicereadonly", TypeName = "bit(1)")]
    public ulong? Devicereadonly { get; set; }

    [Column("limitcommands", TypeName = "bit(1)")]
    public ulong? Limitcommands { get; set; }

    [Column("poilayer")]
    [StringLength(512)]
    public string? Poilayer { get; set; }

    [Column("announcement")]
    [StringLength(4000)]
    public string? Announcement { get; set; }

    [Column("disablereports", TypeName = "bit(1)")]
    public ulong? Disablereports { get; set; }

    [Column("overlayurl")]
    [StringLength(512)]
    public string? Overlayurl { get; set; }

    [Column("fixedemail", TypeName = "bit(1)")]
    public ulong? Fixedemail { get; set; }
}
