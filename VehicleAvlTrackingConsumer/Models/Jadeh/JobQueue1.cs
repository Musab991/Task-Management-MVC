using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh;

[PrimaryKey("Queue", "Id")]
[Table("JobQueue", Schema = "HangfireDev")]
public partial class JobQueue1
{
    [Key]
    public long Id { get; set; }

    public long JobId { get; set; }

    [Key]
    [StringLength(50)]
    public string Queue { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? FetchedAt { get; set; }
}
