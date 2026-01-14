using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class ContractService
{
    public Guid Id { get; set; }

    public Guid ContractId { get; set; }

    public Guid ServiceId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool IsDeleted { get; set; }

    public Guid TenantId { get; set; }

    public double CompletionPercentage { get; set; }

    public Guid? ServiceGroupId { get; set; }

    public int ServiceGroupType { get; set; }

    public double ServiceWeightInGroup { get; set; }

    public int Capacity { get; set; }

    public bool IsAllowedToUpdate { get; set; }

    public virtual Contract Contract { get; set; } = null!;

    public virtual ContractDetail? ContractDetail { get; set; }

    public virtual ICollection<ContractServiceMapGeometry> ContractServiceMapGeometries { get; set; } = new List<ContractServiceMapGeometry>();

    public virtual ICollection<OperationalPlan> OperationalPlans { get; set; } = new List<OperationalPlan>();

    public virtual Service Service { get; set; } = null!;

    public virtual ServiceGroup? ServiceGroup { get; set; }
}
