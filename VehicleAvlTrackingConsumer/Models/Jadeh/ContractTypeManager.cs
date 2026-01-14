using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh;

[Table("ContractTypeManager")]
[Index("ContractTypeId", Name = "IX_ContractTypeManager_ContractTypeId")]
[Index("CreatedDate", Name = "IX_ContractTypeManager_CreatedDate")]
[Index("IsDeleted", Name = "IX_ContractTypeManager_IsDeleted")]
[Index("ManagerId", Name = "IX_ContractTypeManager_ManagerId")]
[Index("TenantId", Name = "IX_ContractTypeManager_TenantId")]
public partial class ContractTypeManager
{
    public Guid ContractTypeId { get; set; }

    public Guid ManagerId { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public bool IsDeleted { get; set; }

    public Guid TenantId { get; set; }

    [Key]
    public Guid Id { get; set; }

    public bool IsContractSupervisor { get; set; }

    [ForeignKey("ContractTypeId")]
    [InverseProperty("ContractTypeManagers")]
    public virtual ContractType ContractType { get; set; } = null!;

    [ForeignKey("ManagerId")]
    [InverseProperty("ContractTypeManagers")]
    public virtual ApplicationUser Manager { get; set; } = null!;
}
