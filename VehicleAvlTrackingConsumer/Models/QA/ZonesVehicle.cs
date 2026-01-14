using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class ZonesVehicle
{
    public Guid ZoneId { get; set; }

    public Guid VehicleTypeId { get; set; }

    public Guid Id { get; set; }

    public virtual VehicleType VehicleType { get; set; } = null!;

    public virtual Zone Zone { get; set; } = null!;
}
