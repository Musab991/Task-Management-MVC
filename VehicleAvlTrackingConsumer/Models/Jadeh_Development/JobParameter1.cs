using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[PrimaryKey("JobId", "Name")]
[Table("JobParameter", Schema = "HangfireDev")]
public partial class JobParameter1
{
    [Key]
    public long JobId { get; set; }

    [Key]
    [StringLength(40)]
    public string Name { get; set; } = null!;

    public string? Value { get; set; }

    [ForeignKey("JobId")]
    [InverseProperty("JobParameter1s")]
    public virtual Job1 Job { get; set; } = null!;
}
