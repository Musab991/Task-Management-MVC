using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class BinGroupMember
{
    public Guid Id { get; set; }

    public string? BinTag { get; set; }

    public Guid BinGroupId { get; set; }

    public Guid BinId { get; set; }

    public virtual Bin Bin { get; set; } = null!;

    public virtual BinGroup BinGroup { get; set; } = null!;
}
