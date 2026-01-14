using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.VehicleAvl;

[Table("tc_statistics")]
[MySqlCharSet("utf8mb3")]
[MySqlCollation("utf8mb3_general_ci")]
public partial class TcStatistic
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("capturetime", TypeName = "timestamp")]
    public DateTime Capturetime { get; set; }

    [Column("activeusers")]
    public int Activeusers { get; set; }

    [Column("activedevices")]
    public int Activedevices { get; set; }

    [Column("requests")]
    public int Requests { get; set; }

    [Column("messagesreceived")]
    public int Messagesreceived { get; set; }

    [Column("messagesstored")]
    public int Messagesstored { get; set; }

    [Column("attributes")]
    [StringLength(4096)]
    public string Attributes { get; set; } = null!;

    [Column("mailsent")]
    public int Mailsent { get; set; }

    [Column("smssent")]
    public int Smssent { get; set; }

    [Column("geocoderrequests")]
    public int Geocoderrequests { get; set; }

    [Column("geolocationrequests")]
    public int Geolocationrequests { get; set; }

    [Column("protocols")]
    [StringLength(4096)]
    public string? Protocols { get; set; }
}
