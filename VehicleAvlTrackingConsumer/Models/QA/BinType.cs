using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class BinType
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public double Weight { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    public int Type { get; set; }

    public int DictionaryId { get; set; }

    public virtual ICollection<Bin> Bins { get; set; } = new List<Bin>();

    public virtual Dictionary Dictionary { get; set; } = null!;
}
