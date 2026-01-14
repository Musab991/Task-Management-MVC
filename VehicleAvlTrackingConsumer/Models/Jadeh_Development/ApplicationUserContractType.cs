using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[Table("ApplicationUserContractType")]
[Index("ApplicationUserId", Name = "IX_ApplicationUserContractType_ApplicationUserId")]
[Index("ContractTypeId", Name = "IX_ApplicationUserContractType_ContractTypeId")]
[Index("CreatedDate", Name = "IX_ApplicationUserContractType_CreatedDate")]
[Index("IsDeleted", Name = "IX_ApplicationUserContractType_IsDeleted")]
[Index("TenantId", Name = "IX_ApplicationUserContractType_TenantId")]
public partial class ApplicationUserContractType
{
    [Key]
    public Guid Id { get; set; }

    public Guid ContractTypeId { get; set; }

    public Guid ApplicationUserId { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public bool IsDeleted { get; set; }

    public Guid TenantId { get; set; }

    public int UserContractRole { get; set; }

    [ForeignKey("ApplicationUserId")]
    [InverseProperty("ApplicationUserContractTypes")]
    public virtual ApplicationUser ApplicationUser { get; set; } = null!;

    [ForeignKey("ContractTypeId")]
    [InverseProperty("ApplicationUserContractTypes")]
    public virtual ContractType ContractType { get; set; } = null!;
}
