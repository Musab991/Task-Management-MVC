using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.VehicleAvl;

[Table("DATABASECHANGELOGLOCK")]
[MySqlCharSet("utf8mb3")]
[MySqlCollation("utf8mb3_general_ci")]
public partial class Databasechangeloglock
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("LOCKED", TypeName = "bit(1)")]
    public ulong Locked { get; set; }

    [Column("LOCKGRANTED", TypeName = "datetime")]
    public DateTime? Lockgranted { get; set; }

    [Column("LOCKEDBY")]
    [StringLength(255)]
    public string? Lockedby { get; set; }
}
