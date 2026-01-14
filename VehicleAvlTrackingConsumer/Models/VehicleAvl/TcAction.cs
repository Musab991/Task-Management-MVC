using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VehicleAvlTrackingConsumer.Models.VehicleAvl;

[Table("tc_actions")]
public partial class TcAction
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("actiontime", TypeName = "timestamp")]
    public DateTime Actiontime { get; set; }

    [Column("address")]
    [StringLength(48)]
    public string? Address { get; set; }

    [Column("userid")]
    public int? Userid { get; set; }

    [Column("actiontype")]
    [StringLength(32)]
    public string Actiontype { get; set; } = null!;

    [Column("objecttype")]
    [StringLength(32)]
    public string? Objecttype { get; set; }

    [Column("objectid")]
    public int? Objectid { get; set; }

    [Column("attributes")]
    [StringLength(4000)]
    public string Attributes { get; set; } = null!;
}
