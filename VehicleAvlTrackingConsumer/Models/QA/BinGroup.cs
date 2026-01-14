using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class BinGroup
{
    public Guid Id { get; set; }

    public Guid TenantId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public virtual ICollection<BinGroupMember> BinGroupMembers { get; set; } = new List<BinGroupMember>();
}
