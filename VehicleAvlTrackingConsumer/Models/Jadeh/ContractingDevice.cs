using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh;

[Index("ContractingCompanyId", Name = "IX_ContractingDevices_ContractingCompanyId")]
[Index("CreatedDate", Name = "IX_ContractingDevices_CreatedDate")]
[Index("IsDeleted", Name = "IX_ContractingDevices_IsDeleted")]
[Index("TenantId", Name = "IX_ContractingDevices_TenantId")]
public partial class ContractingDevice
{
    [Key]
    public Guid Id { get; set; }

    public Guid ContractingCompanyId { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    [ForeignKey("ContractingCompanyId")]
    [InverseProperty("ContractingDevices")]
    public virtual ContractingCompany ContractingCompany { get; set; } = null!;
}
