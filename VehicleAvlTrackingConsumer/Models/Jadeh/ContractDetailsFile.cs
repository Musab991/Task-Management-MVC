using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh;

[Index("ContractServiceId", Name = "IX_ContractDetailsFiles_ContractServiceId")]
[Index("CreatedDate", Name = "IX_ContractDetailsFiles_CreatedDate")]
[Index("IsDeleted", Name = "IX_ContractDetailsFiles_IsDeleted")]
[Index("TenantId", Name = "IX_ContractDetailsFiles_TenantId")]
public partial class ContractDetailsFile
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(255)]
    public string FileName { get; set; } = null!;

    [StringLength(500)]
    public string FilePath { get; set; } = null!;

    public Guid ContractServiceId { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public bool IsDeleted { get; set; }

    public Guid TenantId { get; set; }

    [ForeignKey("ContractServiceId")]
    [InverseProperty("ContractDetailsFiles")]
    public virtual ContractDetail ContractService { get; set; } = null!;
}
