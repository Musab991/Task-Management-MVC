using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class Job1
{
    public long Id { get; set; }

    public long? StateId { get; set; }

    public string? StateName { get; set; }

    public string InvocationData { get; set; } = null!;

    public string Arguments { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? ExpireAt { get; set; }

    public virtual ICollection<JobParameter1> JobParameter1s { get; set; } = new List<JobParameter1>();

    public virtual ICollection<State1> State1s { get; set; } = new List<State1>();
}
