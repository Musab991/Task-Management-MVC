using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class DisposalPointCategory
{
    public int Id { get; set; }

    public int? DictionaryId { get; set; }

    public string? ColorHex { get; set; }

    public int Type { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    public virtual Dictionary? Dictionary { get; set; }

    public virtual ICollection<DisposalPoint> DisposalPoints { get; set; } = new List<DisposalPoint>();
}
