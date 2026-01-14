using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[PrimaryKey("JobId", "Name")]
[Table("JobParameter", Schema = "Hangfire")]
public partial class JobParameter
{
    [Key]
    public long JobId { get; set; }

    [Key]
    [StringLength(40)]
    public string Name { get; set; } = null!;

    public string? Value { get; set; }

    [ForeignKey("JobId")]
    [InverseProperty("JobParameters")]
    public virtual Job Job { get; set; } = null!;
}
