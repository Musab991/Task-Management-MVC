using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class ContractTypeTransporter
{
    public Guid ContractTypeId { get; set; }

    public Guid TransporterId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool IsDeleted { get; set; }

    public Guid TenantId { get; set; }

    public Guid Id { get; set; }

    public virtual ContractType ContractType { get; set; } = null!;

    public virtual ApplicationUser Transporter { get; set; } = null!;
}
