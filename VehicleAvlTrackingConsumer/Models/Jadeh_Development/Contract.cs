using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[Index("ContractTypeId", Name = "IX_Contracts_ContractTypeId")]
[Index("ContractingCompanyId", Name = "IX_Contracts_ContractingCompanyId")]
[Index("CreatedDate", Name = "IX_Contracts_CreatedDate")]
[Index("IsDeleted", Name = "IX_Contracts_IsDeleted")]
[Index("Number", Name = "IX_Contracts_Number", IsUnique = true)]
[Index("TenantId", Name = "IX_Contracts_TenantId")]
public partial class Contract
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(50)]
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

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public bool IsDeleted { get; set; }

    public Guid TenantId { get; set; }

    public double CompletionPercentage { get; set; }

    [InverseProperty("Contract")]
    public virtual ICollection<ContractFile> ContractFiles { get; set; } = new List<ContractFile>();

    [InverseProperty("Contract")]
    public virtual ICollection<ContractGroup> ContractGroups { get; set; } = new List<ContractGroup>();

    [InverseProperty("Entity")]
    public virtual ICollection<ContractLocalization> ContractLocalizations { get; set; } = new List<ContractLocalization>();

    [InverseProperty("Contract")]
    public virtual ICollection<ContractMapGeometry> ContractMapGeometries { get; set; } = new List<ContractMapGeometry>();

    [InverseProperty("Contract")]
    public virtual ICollection<ContractServiceMapGeometry> ContractServiceMapGeometries { get; set; } = new List<ContractServiceMapGeometry>();

    [InverseProperty("Contract")]
    public virtual ICollection<ContractService> ContractServices { get; set; } = new List<ContractService>();

    [ForeignKey("ContractTypeId")]
    [InverseProperty("Contracts")]
    public virtual ContractType ContractType { get; set; } = null!;

    [ForeignKey("ContractingCompanyId")]
    [InverseProperty("Contracts")]
    public virtual ContractingCompany ContractingCompany { get; set; } = null!;

    [InverseProperty("Contract")]
    public virtual ICollection<OperationalPlan> OperationalPlans { get; set; } = new List<OperationalPlan>();
}
