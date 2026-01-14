using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.VehicleAvl;

[Table("tc_reports")]
[Index("Calendarid", Name = "fk_reports_calendarid")]
[MySqlCharSet("utf8mb3")]
[MySqlCollation("utf8mb3_general_ci")]
public partial class TcReport
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("type")]
    [StringLength(32)]
    public string Type { get; set; } = null!;

    [Column("description")]
    [StringLength(128)]
    public string Description { get; set; } = null!;

    [Column("calendarid")]
    public int Calendarid { get; set; }

    [Column("attributes")]
    [StringLength(4000)]
    public string Attributes { get; set; } = null!;

    [ForeignKey("Calendarid")]
    [InverseProperty("TcReports")]
    public virtual TcCalendar Calendar { get; set; } = null!;

    [ForeignKey("Reportid")]
    [InverseProperty("Reports")]
    public virtual ICollection<TcDevice> Devices { get; set; } = new List<TcDevice>();

    [ForeignKey("Reportid")]
    [InverseProperty("Reports")]
    public virtual ICollection<TcGroup> Groups { get; set; } = new List<TcGroup>();

    [ForeignKey("Reportid")]
    [InverseProperty("Reports")]
    public virtual ICollection<TcUser> Users { get; set; } = new List<TcUser>();
}
