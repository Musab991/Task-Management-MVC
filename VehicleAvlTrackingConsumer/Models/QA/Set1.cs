using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class Set1
{
    public string Key { get; set; } = null!;

    public double Score { get; set; }

    public string Value { get; set; } = null!;

    public DateTime? ExpireAt { get; set; }
}
