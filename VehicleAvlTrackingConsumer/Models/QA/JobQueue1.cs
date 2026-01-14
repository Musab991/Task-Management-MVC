using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class JobQueue1
{
    public long Id { get; set; }

    public long JobId { get; set; }

    public string Queue { get; set; } = null!;

    public DateTime? FetchedAt { get; set; }
}
