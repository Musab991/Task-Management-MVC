using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class ApplicationUserContractType
{
    public Guid Id { get; set; }

    public Guid ContractTypeId { get; set; }

    public Guid ApplicationUserId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool IsDeleted { get; set; }

    public Guid TenantId { get; set; }

    public int UserContractRole { get; set; }

    public virtual ApplicationUser ApplicationUser { get; set; } = null!;

    public virtual ContractType ContractType { get; set; } = null!;
}
