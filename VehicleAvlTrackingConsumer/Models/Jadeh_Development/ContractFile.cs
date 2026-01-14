using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[Index("ContractId", Name = "IX_ContractFiles_ContractId")]
[Index("CreatedDate", Name = "IX_ContractFiles_CreatedDate")]
[Index("IsDeleted", Name = "IX_ContractFiles_IsDeleted")]
[Index("TenantId", Name = "IX_ContractFiles_TenantId")]
public partial class ContractFile
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(255)]
    public string FileName { get; set; } = null!;

    [StringLength(500)]
    public string FilePath { get; set; } = null!;

    public Guid ContractId { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public bool IsDeleted { get; set; }

    public Guid TenantId { get; set; }

    [ForeignKey("ContractId")]
    [InverseProperty("ContractFiles")]
    public virtual Contract Contract { get; set; } = null!;
}
