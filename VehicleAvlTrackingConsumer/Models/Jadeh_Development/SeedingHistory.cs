using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[PrimaryKey("SeedTypeName", "SeedType", "SeedVersion")]
[Table("__SeedingHistory")]
public partial class SeedingHistory
{
    [Key]
    [StringLength(225)]
    public string SeedTypeName { get; set; } = null!;

    [Key]
    [StringLength(100)]
    public string SeedType { get; set; } = null!;

    [Key]
    [StringLength(5)]
    public string SeedVersion { get; set; } = null!;
}
