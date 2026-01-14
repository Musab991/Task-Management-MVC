using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.VehicleAvl;

[Table("tc_orders")]
[MySqlCharSet("utf8mb3")]
[MySqlCollation("utf8mb3_general_ci")]
public partial class TcOrder
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("uniqueid")]
    [StringLength(128)]
    public string Uniqueid { get; set; } = null!;

    [Column("description")]
    [StringLength(512)]
    public string? Description { get; set; }

    [Column("fromaddress")]
    [StringLength(512)]
    public string? Fromaddress { get; set; }

    [Column("toaddress")]
    [StringLength(512)]
    public string? Toaddress { get; set; }

    [Column("attributes")]
    [StringLength(4000)]
    public string Attributes { get; set; } = null!;

    [ForeignKey("Orderid")]
    [InverseProperty("Orders")]
    public virtual ICollection<TcDevice> Devices { get; set; } = new List<TcDevice>();

    [ForeignKey("Orderid")]
    [InverseProperty("Orders")]
    public virtual ICollection<TcGroup> Groups { get; set; } = new List<TcGroup>();

    [ForeignKey("Orderid")]
    [InverseProperty("Orders")]
    public virtual ICollection<TcUser> Users { get; set; } = new List<TcUser>();
}
