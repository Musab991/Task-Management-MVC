using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class ContractAudiTrail
{
    public Guid Id { get; set; }

    public string? Note { get; set; }

    public int OldStatusId { get; set; }

    public int NewStatusId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool IsDeleted { get; set; }

    public Guid TenantId { get; set; }

    public Guid ContractId { get; set; }

    public Guid? AuditTrailApplicationUserId { get; set; }

    public virtual ApplicationUser? AuditTrailApplicationUser { get; set; }
}
