using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class JobParameter1
{
    public long JobId { get; set; }

    public string Name { get; set; } = null!;

    public string? Value { get; set; }

    public virtual Job1 Job { get; set; } = null!;
}
