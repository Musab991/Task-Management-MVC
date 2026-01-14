using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh;

[Index("CreatedDate", Name = "IX_ContractTypes_CreatedDate")]
[Index("DictionaryId", Name = "IX_ContractTypes_DictionaryId")]
[Index("IsDeleted", Name = "IX_ContractTypes_IsDeleted")]
[Index("TenantId", Name = "IX_ContractTypes_TenantId")]
public partial class ContractType
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(100)]
    public string Name { get; set; } = null!;

    [StringLength(500)]
    public string? Description { get; set; }

    public bool HasContract { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public bool IsDeleted { get; set; }

    public Guid TenantId { get; set; }

    public int Type { get; set; }

    public bool IsConfigurationCompleted { get; set; }

    public int? DictionaryId { get; set; }

    [InverseProperty("ContractType")]
    public virtual ICollection<ApplicationUserContractType> ApplicationUserContractTypes { get; set; } = new List<ApplicationUserContractType>();

    [InverseProperty("ContractType")]
    public virtual ICollection<Bin> Bins { get; set; } = new List<Bin>();

    [InverseProperty("ContractType")]
    public virtual ICollection<ContractTypeManager> ContractTypeManagers { get; set; } = new List<ContractTypeManager>();

    [InverseProperty("ContractType")]
    public virtual ICollection<ContractTypeTransporter> ContractTypeTransporters { get; set; } = new List<ContractTypeTransporter>();

    [InverseProperty("ContractType")]
    public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();

    [InverseProperty("ContractType")]
    public virtual ICollection<Crew> Crews { get; set; } = new List<Crew>();

    [ForeignKey("DictionaryId")]
    [InverseProperty("ContractTypes")]
    public virtual Dictionary? Dictionary { get; set; }

    [InverseProperty("ContractType")]
    public virtual ICollection<DisposalPoint> DisposalPoints { get; set; } = new List<DisposalPoint>();

    [InverseProperty("ContractType")]
    public virtual ICollection<OvernightPoint> OvernightPoints { get; set; } = new List<OvernightPoint>();

    [InverseProperty("ContractType")]
    public virtual ICollection<ServiceGroupContractType> ServiceGroupContractTypes { get; set; } = new List<ServiceGroupContractType>();

    [InverseProperty("ContractType")]
    public virtual ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
}
