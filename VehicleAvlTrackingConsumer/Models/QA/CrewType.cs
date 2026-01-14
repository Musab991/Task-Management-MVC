using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class CrewType
{
    public Guid Id { get; set; }

    public int Type { get; set; }

    public string? Name { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    public virtual ICollection<Crew> Crews { get; set; } = new List<Crew>();

    public virtual ICollection<ServiceCrewType> ServiceCrewTypes { get; set; } = new List<ServiceCrewType>();
}
