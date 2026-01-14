using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.VehicleAvl;

[Table("tc_attributes")]
[MySqlCharSet("utf8mb3")]
[MySqlCollation("utf8mb3_general_ci")]
public partial class TcAttribute
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("description")]
    [StringLength(4000)]
    public string Description { get; set; } = null!;

    [Column("type")]
    [StringLength(128)]
    public string Type { get; set; } = null!;

    [Column("attribute")]
    [StringLength(128)]
    public string Attribute { get; set; } = null!;

    [Column("expression")]
    [StringLength(4000)]
    public string Expression { get; set; } = null!;

    [Column("PRIORITY")]
    public sbyte Priority { get; set; }

    [ForeignKey("Attributeid")]
    [InverseProperty("AttributesNavigation")]
    public virtual ICollection<TcDevice> Devices { get; set; } = new List<TcDevice>();

    [ForeignKey("Attributeid")]
    [InverseProperty("AttributesNavigation")]
    public virtual ICollection<TcGroup> Groups { get; set; } = new List<TcGroup>();

    [ForeignKey("Attributeid")]
    [InverseProperty("AttributesNavigation")]
    public virtual ICollection<TcUser> Users { get; set; } = new List<TcUser>();
}
