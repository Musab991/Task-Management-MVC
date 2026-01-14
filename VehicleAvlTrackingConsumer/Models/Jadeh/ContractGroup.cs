using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh;

[PrimaryKey("ContractId", "ServiceGroupId")]
[Table("ContractGroup")]
[Index("CreatedDate", Name = "IX_ContractGroup_CreatedDate")]
[Index("IsDeleted", Name = "IX_ContractGroup_IsDeleted")]
[Index("ServiceGroupId", Name = "IX_ContractGroup_ServiceGroupId")]
[Index("TenantId", Name = "IX_ContractGroup_TenantId")]
public partial class ContractGroup
{
    [Key]
    public Guid ContractId { get; set; }

    [Key]
    public Guid ServiceGroupId { get; set; }

    public double GroupCompletionPercentage { get; set; }

    public double GroupWeightInContract { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public bool IsDeleted { get; set; }

    public Guid TenantId { get; set; }

    [ForeignKey("ContractId")]
    [InverseProperty("ContractGroups")]
    public virtual Contract Contract { get; set; } = null!;

    [ForeignKey("ServiceGroupId")]
    [InverseProperty("ContractGroups")]
    public virtual ServiceGroup ServiceGroup { get; set; } = null!;
}
