using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class ContractFile
{
    public Guid Id { get; set; }

    public string FileName { get; set; } = null!;

    public string FilePath { get; set; } = null!;

    public Guid ContractId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool IsDeleted { get; set; }

    public Guid TenantId { get; set; }

    public virtual Contract Contract { get; set; } = null!;
}
