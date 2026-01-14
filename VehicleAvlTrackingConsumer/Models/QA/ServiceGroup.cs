using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class ServiceGroup
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public Guid ContractUiConfigurationId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    public bool IsDeleted { get; set; }

    public int Type { get; set; }

    public double WeightInContract { get; set; }

    public Guid? ServiceGroupTypeId { get; set; }

    public virtual ICollection<ContractGroup> ContractGroups { get; set; } = new List<ContractGroup>();

    public virtual ICollection<ContractService> ContractServices { get; set; } = new List<ContractService>();

    public virtual ContractUiConfiguration? ContractUiConfiguration { get; set; }

    public virtual ICollection<ServiceGroupContractType> ServiceGroupContractTypes { get; set; } = new List<ServiceGroupContractType>();

    public virtual ICollection<ServiceGroupLocalization> ServiceGroupLocalizations { get; set; } = new List<ServiceGroupLocalization>();

    public virtual ICollection<ServiceGroupServiceGroupType> ServiceGroupServiceGroupTypes { get; set; } = new List<ServiceGroupServiceGroupType>();

    public virtual ServiceGroupType? ServiceGroupType { get; set; }

    public virtual ICollection<Service> Services { get; set; } = new List<Service>();
}
