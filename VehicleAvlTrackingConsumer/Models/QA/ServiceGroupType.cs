using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class ServiceGroupType
{
    public Guid Id { get; set; }

    public int Type { get; set; }

    public DateTime CreatedDate { get; set; }

    public int DictionaryId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    public bool IsDeleted { get; set; }

    public virtual Dictionary Dictionary { get; set; } = null!;

    public virtual ICollection<ServiceGroupServiceGroupType> ServiceGroupServiceGroupTypes { get; set; } = new List<ServiceGroupServiceGroupType>();

    public virtual ICollection<ServiceGroup> ServiceGroups { get; set; } = new List<ServiceGroup>();
}
