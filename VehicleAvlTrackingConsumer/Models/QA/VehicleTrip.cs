using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class VehicleTrip
{
    public Guid Id { get; set; }

    public Guid TripId { get; set; }

    public Guid VehicleId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public bool IsDeleted { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public Guid TenantId { get; set; }

    public virtual Trip Trip { get; set; } = null!;

    public virtual Vehicle Vehicle { get; set; } = null!;
}
