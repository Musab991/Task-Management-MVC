using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh;

[Table("Schema", Schema = "HangfireDev")]
public partial class Schema1
{
    [Key]
    public int Version { get; set; }
}
