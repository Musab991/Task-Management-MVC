using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class Zone
{
    public Guid Id { get; set; }

    public string? GeometryJson { get; set; }

    public Guid ZoneTypeId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    public bool IsDeleted { get; set; }

    public TimeOnly AllowedAccessTimeEnd { get; set; }

    public TimeOnly AllowedAccessTimeStart { get; set; }

    public DateTime? LastAccessTime { get; set; }

    public string? GeoJson { get; set; }

    public virtual ZoneType ZoneType { get; set; } = null!;

    public virtual ICollection<ZonesLocalization> ZonesLocalizations { get; set; } = new List<ZonesLocalization>();

    public virtual ICollection<ZonesVehicle> ZonesVehicles { get; set; } = new List<ZonesVehicle>();
}
