using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class ZoneType
{
    public Guid Id { get; set; }

    public string? Color { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<ZoneTypeLocalization> ZoneTypeLocalizations { get; set; } = new List<ZoneTypeLocalization>();

    public virtual ICollection<Zone> Zones { get; set; } = new List<Zone>();
}
