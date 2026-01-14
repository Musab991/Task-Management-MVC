using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class PrivilegeGroup
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    public int? PrivilegeGroupId { get; set; }

    public int? DictionaryId { get; set; }

    public virtual Dictionary? Dictionary { get; set; }

    public virtual ICollection<Privilege> Privileges { get; set; } = new List<Privilege>();
}
