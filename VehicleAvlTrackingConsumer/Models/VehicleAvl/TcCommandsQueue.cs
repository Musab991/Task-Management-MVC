using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.VehicleAvl;

[Table("tc_commands_queue")]
[Index("Deviceid", Name = "idx_commands_queue_deviceid")]
[MySqlCharSet("utf8mb3")]
[MySqlCollation("utf8mb3_general_ci")]
public partial class TcCommandsQueue
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("deviceid")]
    public int Deviceid { get; set; }

    [Column("type")]
    [StringLength(128)]
    public string Type { get; set; } = null!;

    [Column("textchannel", TypeName = "bit(1)")]
    public ulong Textchannel { get; set; }

    [Column("attributes")]
    [StringLength(4000)]
    public string Attributes { get; set; } = null!;

    [ForeignKey("Deviceid")]
    [InverseProperty("TcCommandsQueues")]
    public virtual TcDevice Device { get; set; } = null!;
}
