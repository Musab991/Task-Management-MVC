using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[Table("Job", Schema = "HangfireDev")]
public partial class Job1
{
    [Key]
    public long Id { get; set; }

    public long? StateId { get; set; }

    [StringLength(20)]
    public string? StateName { get; set; }

    public string InvocationData { get; set; } = null!;

    public string Arguments { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedAt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpireAt { get; set; }

    [InverseProperty("Job")]
    public virtual ICollection<JobParameter1> JobParameter1s { get; set; } = new List<JobParameter1>();

    [InverseProperty("Job")]
    public virtual ICollection<State1> State1s { get; set; } = new List<State1>();
}
