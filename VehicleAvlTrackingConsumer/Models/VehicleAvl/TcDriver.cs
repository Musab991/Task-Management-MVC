using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.VehicleAvl;

[Table("tc_drivers")]
[Index("Uniqueid", Name = "idx_drivers_uniqueid", IsUnique = true)]
[MySqlCharSet("utf8mb3")]
[MySqlCollation("utf8mb3_general_ci")]
public partial class TcDriver
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [StringLength(128)]
    public string Name { get; set; } = null!;

    [Column("uniqueid")]
    [StringLength(128)]
    public string Uniqueid { get; set; } = null!;

    [Column("attributes")]
    [StringLength(4000)]
    public string Attributes { get; set; } = null!;

    [ForeignKey("Driverid")]
    [InverseProperty("Drivers")]
    public virtual ICollection<TcDevice> Devices { get; set; } = new List<TcDevice>();

    [ForeignKey("Driverid")]
    [InverseProperty("Drivers")]
    public virtual ICollection<TcGroup> Groups { get; set; } = new List<TcGroup>();

    [ForeignKey("Driverid")]
    [InverseProperty("Drivers")]
    public virtual ICollection<TcUser> Users { get; set; } = new List<TcUser>();
}
