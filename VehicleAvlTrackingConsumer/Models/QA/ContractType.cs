using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class ContractType
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public bool HasContract { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool IsDeleted { get; set; }

    public Guid TenantId { get; set; }

    public int Type { get; set; }

    public bool IsConfigurationCompleted { get; set; }

    public int? DictionaryId { get; set; }

    public virtual ICollection<ApplicationUserContractType> ApplicationUserContractTypes { get; set; } = new List<ApplicationUserContractType>();

    public virtual ICollection<Bin> Bins { get; set; } = new List<Bin>();

    public virtual ICollection<ContractTypeManager> ContractTypeManagers { get; set; } = new List<ContractTypeManager>();

    public virtual ICollection<ContractTypeTransporter> ContractTypeTransporters { get; set; } = new List<ContractTypeTransporter>();

    public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();

    public virtual ICollection<Crew> Crews { get; set; } = new List<Crew>();

    public virtual Dictionary? Dictionary { get; set; }

    public virtual ICollection<DisposalPoint> DisposalPoints { get; set; } = new List<DisposalPoint>();

    public virtual ICollection<OvernightPoint> OvernightPoints { get; set; } = new List<OvernightPoint>();

    public virtual ICollection<ServiceGroupContractType> ServiceGroupContractTypes { get; set; } = new List<ServiceGroupContractType>();

    public virtual ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
}
