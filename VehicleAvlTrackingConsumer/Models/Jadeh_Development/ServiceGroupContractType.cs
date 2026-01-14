using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[PrimaryKey("ServiceGroupId", "ContractTypeId")]
[Table("ServiceGroupContractType")]
[Index("ContractTypeId", Name = "IX_ServiceGroupContractType_ContractTypeId")]
[Index("CreatedDate", Name = "IX_ServiceGroupContractType_CreatedDate")]
[Index("IsDeleted", Name = "IX_ServiceGroupContractType_IsDeleted")]
[Index("TenantId", Name = "IX_ServiceGroupContractType_TenantId")]
public partial class ServiceGroupContractType
{
    [Key]
    public Guid ServiceGroupId { get; set; }

    [Key]
    public Guid ContractTypeId { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    [ForeignKey("ContractTypeId")]
    [InverseProperty("ServiceGroupContractTypes")]
    public virtual ContractType ContractType { get; set; } = null!;

    [ForeignKey("ServiceGroupId")]
    [InverseProperty("ServiceGroupContractTypes")]
    public virtual ServiceGroup ServiceGroup { get; set; } = null!;
}
