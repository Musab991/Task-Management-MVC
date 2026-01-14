using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class Contract
{
    public Guid Id { get; set; }

    public string Number { get; set; } = null!;

    public int ContractName { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public bool IsResidential { get; set; }

    public bool IsCommercial { get; set; }

    public int Status { get; set; }

    public Guid ContractingCompanyId { get; set; }

    public Guid ContractTypeId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool IsDeleted { get; set; }

    public Guid TenantId { get; set; }

    public double CompletionPercentage { get; set; }

    public virtual ICollection<ContractFile> ContractFiles { get; set; } = new List<ContractFile>();

    public virtual ICollection<ContractGroup> ContractGroups { get; set; } = new List<ContractGroup>();

    public virtual ICollection<ContractLocalization> ContractLocalizations { get; set; } = new List<ContractLocalization>();

    public virtual ICollection<ContractMapGeometry> ContractMapGeometries { get; set; } = new List<ContractMapGeometry>();

    public virtual ICollection<ContractServiceMapGeometry> ContractServiceMapGeometries { get; set; } = new List<ContractServiceMapGeometry>();

    public virtual ICollection<ContractService> ContractServices { get; set; } = new List<ContractService>();

    public virtual ContractType ContractType { get; set; } = null!;

    public virtual ContractingCompany ContractingCompany { get; set; } = null!;

    public virtual ICollection<OperationalPlan> OperationalPlans { get; set; } = new List<OperationalPlan>();
}
