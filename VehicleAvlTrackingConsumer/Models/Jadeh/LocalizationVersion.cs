using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh;

[PrimaryKey("Localizer", "Version")]
[Table("LocalizationVersion")]
public partial class LocalizationVersion
{
    [Key]
    [StringLength(225)]
    public string Localizer { get; set; } = null!;

    [Key]
    [StringLength(5)]
    public string Version { get; set; } = null!;
}
