using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.VehicleAvl;

[Table("tc_keystore")]
[MySqlCharSet("utf8mb3")]
[MySqlCollation("utf8mb3_general_ci")]
public partial class TcKeystore
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("publickey", TypeName = "mediumblob")]
    public byte[] Publickey { get; set; } = null!;

    [Column("privatekey", TypeName = "mediumblob")]
    public byte[] Privatekey { get; set; } = null!;
}
