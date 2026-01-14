using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class Server1
{
    public string Id { get; set; } = null!;

    public string? Data { get; set; }

    public DateTime LastHeartbeat { get; set; }
}
