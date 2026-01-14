using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[Table("AggregatedCounter", Schema = "Hangfire")]
public partial class AggregatedCounter
{
    [Key]
    [StringLength(100)]
    public string Key { get; set; } = null!;

    public long Value { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpireAt { get; set; }
}
