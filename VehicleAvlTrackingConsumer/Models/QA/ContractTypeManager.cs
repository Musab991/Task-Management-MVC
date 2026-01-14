using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class ContractTypeManager
{
    public Guid ContractTypeId { get; set; }

    public Guid ManagerId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool IsDeleted { get; set; }

    public Guid TenantId { get; set; }

    public Guid Id { get; set; }

    public bool IsContractSupervisor { get; set; }

    public virtual ContractType ContractType { get; set; } = null!;

    public virtual ApplicationUser Manager { get; set; } = null!;
}
