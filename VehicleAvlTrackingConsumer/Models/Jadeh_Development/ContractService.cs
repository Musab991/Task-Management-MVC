using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[Index("ContractId", Name = "IX_ContractServices_ContractId")]
[Index("CreatedDate", Name = "IX_ContractServices_CreatedDate")]
[Index("IsDeleted", Name = "IX_ContractServices_IsDeleted")]
[Index("ServiceGroupId", Name = "IX_ContractServices_ServiceGroupId")]
[Index("ServiceId", Name = "IX_ContractServices_ServiceId")]
[Index("TenantId", Name = "IX_ContractServices_TenantId")]
public partial class ContractService
{
    [Key]
    public Guid Id { get; set; }

    public Guid ContractId { get; set; }

    public Guid ServiceId { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public bool IsDeleted { get; set; }

    public Guid TenantId { get; set; }

    public double CompletionPercentage { get; set; }

    public Guid? ServiceGroupId { get; set; }

    public int ServiceGroupType { get; set; }

    public double ServiceWeightInGroup { get; set; }

    public int Capacity { get; set; }

    public bool IsAllowedToUpdate { get; set; }

    [ForeignKey("ContractId")]
    [InverseProperty("ContractServices")]
    public virtual Contract Contract { get; set; } = null!;

    [InverseProperty("ContractService")]
    public virtual ContractDetail? ContractDetail { get; set; }

    [InverseProperty("ContractService")]
    public virtual ICollection<ContractServiceMapGeometry> ContractServiceMapGeometries { get; set; } = new List<ContractServiceMapGeometry>();

    [InverseProperty("ContractService")]
    public virtual ICollection<OperationalPlan> OperationalPlans { get; set; } = new List<OperationalPlan>();

    [ForeignKey("ServiceId")]
    [InverseProperty("ContractServices")]
    public virtual Service Service { get; set; } = null!;

    [ForeignKey("ServiceGroupId")]
    [InverseProperty("ContractServices")]
    public virtual ServiceGroup? ServiceGroup { get; set; }
}
