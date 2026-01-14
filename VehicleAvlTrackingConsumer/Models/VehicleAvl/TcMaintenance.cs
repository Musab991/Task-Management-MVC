using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.VehicleAvl;

[Table("tc_maintenances")]
[MySqlCharSet("utf8mb3")]
[MySqlCollation("utf8mb3_general_ci")]
public partial class TcMaintenance
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [StringLength(4000)]
    public string Name { get; set; } = null!;

    [Column("type")]
    [StringLength(128)]
    public string Type { get; set; } = null!;

    [Column("start")]
    public double Start { get; set; }

    [Column("period")]
    public double Period { get; set; }

    [Column("attributes")]
    [StringLength(4000)]
    public string Attributes { get; set; } = null!;

    [ForeignKey("Maintenanceid")]
    [InverseProperty("Maintenances")]
    public virtual ICollection<TcDevice> Devices { get; set; } = new List<TcDevice>();

    [ForeignKey("Maintenanceid")]
    [InverseProperty("Maintenances")]
    public virtual ICollection<TcGroup> Groups { get; set; } = new List<TcGroup>();

    [ForeignKey("Maintenanceid")]
    [InverseProperty("Maintenances")]
    public virtual ICollection<TcUser> Users { get; set; } = new List<TcUser>();
}
