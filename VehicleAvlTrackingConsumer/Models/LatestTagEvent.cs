using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models;

public partial class LatestTagEvent
{
    public Guid Id { get; set; }

    public string? Tag { get; set; }

    public string? TrackingDeviceNumber { get; set; }

    public Guid VehicleId { get; set; }

    public Guid BinId { get; set; }

    public bool IsDeleted { get; set; }

    public string? Createdby { get; set; }

    public Guid ModifiedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime ModifiedDate { get; set; }

    public Guid TenantId { get; set; }
}
