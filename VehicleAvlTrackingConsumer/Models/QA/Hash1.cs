using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class Hash1
{
    public string Key { get; set; } = null!;

    public string Field { get; set; } = null!;

    public string? Value { get; set; }

    public DateTime? ExpireAt { get; set; }
}
