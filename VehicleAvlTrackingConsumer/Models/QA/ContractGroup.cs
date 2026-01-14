using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class ContractGroup
{
    public Guid ContractId { get; set; }

    public Guid ServiceGroupId { get; set; }

    public double GroupCompletionPercentage { get; set; }

    public double GroupWeightInContract { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool IsDeleted { get; set; }

    public Guid TenantId { get; set; }

    public virtual Contract Contract { get; set; } = null!;

    public virtual ServiceGroup ServiceGroup { get; set; } = null!;
}
