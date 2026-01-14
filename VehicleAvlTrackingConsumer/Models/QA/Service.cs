using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class Service
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public Guid ServiceGroupId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    public bool IsDeleted { get; set; }

    public int GroupType { get; set; }

    public int Type { get; set; }

    public Guid ServiceUiConfigurationId { get; set; }

    public double WeightInGroup { get; set; }

    public virtual ICollection<ContractService> ContractServices { get; set; } = new List<ContractService>();

    public virtual ICollection<ServiceCrewType> ServiceCrewTypes { get; set; } = new List<ServiceCrewType>();

    public virtual ICollection<ServiceGeometryType> ServiceGeometryTypes { get; set; } = new List<ServiceGeometryType>();

    public virtual ServiceGroup ServiceGroup { get; set; } = null!;

    public virtual ICollection<ServiceLocalization> ServiceLocalizations { get; set; } = new List<ServiceLocalization>();

    public virtual ServiceUiConfiguration? ServiceUiConfiguration { get; set; }

    public virtual ICollection<ServiceVehicleType> ServiceVehicleTypes { get; set; } = new List<ServiceVehicleType>();
}
