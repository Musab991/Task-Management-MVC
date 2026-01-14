using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class ServiceGroupContractType
{
    public Guid ServiceGroupId { get; set; }

    public Guid ContractTypeId { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    public virtual ContractType ContractType { get; set; } = null!;

    public virtual ServiceGroup ServiceGroup { get; set; } = null!;
}
