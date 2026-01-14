using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.VehicleAvl;

[PrimaryKey("Devicetime", "Id")]
[Table("tc_positions")]
[Index("Deviceid", "Fixtime", Name = "position_deviceid_fixtime")]
[Index("Id", "Devicetime", Name = "uq_pos_id", IsUnique = true)]
[MySqlCharSet("utf8mb3")]
[MySqlCollation("utf8mb3_general_ci")]
public partial class TcPosition
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("protocol")]
    [StringLength(128)]
    public string? Protocol { get; set; }

    [Column("deviceid")]
    public int Deviceid { get; set; }

    [Column("servertime", TypeName = "timestamp")]
    public DateTime Servertime { get; set; }

    [Key]
    [Column("devicetime", TypeName = "datetime")]
    public DateTime Devicetime { get; set; }

    [Column("fixtime", TypeName = "timestamp")]
    public DateTime Fixtime { get; set; }

    [Column("valid", TypeName = "bit(1)")]
    public ulong Valid { get; set; }

    [Column("latitude")]
    public double Latitude { get; set; }

    [Column("longitude")]
    public double Longitude { get; set; }

    [Column("altitude")]
    public float Altitude { get; set; }

    [Column("speed")]
    public float Speed { get; set; }

    [Column("course")]
    public float Course { get; set; }

    [Column("address")]
    [StringLength(512)]
    public string? Address { get; set; }

    [Column("attributes")]
    [StringLength(4000)]
    public string? Attributes { get; set; }

    [Column("accuracy")]
    public double Accuracy { get; set; }

    [Column("network")]
    [StringLength(4000)]
    public string? Network { get; set; }

    [Column("geofenceids")]
    [StringLength(128)]
    public string? Geofenceids { get; set; }
}
