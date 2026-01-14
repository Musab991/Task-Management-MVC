using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class List1
{
    public long Id { get; set; }

    public string Key { get; set; } = null!;

    public string? Value { get; set; }

    public DateTime? ExpireAt { get; set; }
}
