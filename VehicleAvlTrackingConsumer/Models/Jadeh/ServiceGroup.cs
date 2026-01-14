using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh;

[Index("CreatedDate", Name = "IX_ServiceGroups_CreatedDate")]
[Index("IsDeleted", Name = "IX_ServiceGroups_IsDeleted")]
[Index("ServiceGroupTypeId", Name = "IX_ServiceGroups_ServiceGroupTypeID")]
[Index("TenantId", Name = "IX_ServiceGroups_TenantId")]
public partial class ServiceGroup
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(255)]
    public string Name { get; set; } = null!;

    public Guid ContractUiConfigurationId { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    public bool IsDeleted { get; set; }

    public int Type { get; set; }

    public double WeightInContract { get; set; }

    [Column("ServiceGroupTypeID")]
    public Guid? ServiceGroupTypeId { get; set; }

    [InverseProperty("ServiceGroup")]
    public virtual ICollection<ContractGroup> ContractGroups { get; set; } = new List<ContractGroup>();

    [InverseProperty("ServiceGroup")]
    public virtual ICollection<ContractService> ContractServices { get; set; } = new List<ContractService>();

    [InverseProperty("ServiceGroup")]
    public virtual ContractUiConfiguration? ContractUiConfiguration { get; set; }

    [InverseProperty("ServiceGroup")]
    public virtual ICollection<ServiceGroupContractType> ServiceGroupContractTypes { get; set; } = new List<ServiceGroupContractType>();

    [InverseProperty("Entity")]
    public virtual ICollection<ServiceGroupLocalization> ServiceGroupLocalizations { get; set; } = new List<ServiceGroupLocalization>();

    [InverseProperty("ServiceGroup")]
    public virtual ICollection<ServiceGroupServiceGroupType> ServiceGroupServiceGroupTypes { get; set; } = new List<ServiceGroupServiceGroupType>();

    [ForeignKey("ServiceGroupTypeId")]
    [InverseProperty("ServiceGroups")]
    public virtual ServiceGroupType? ServiceGroupType { get; set; }

    [InverseProperty("ServiceGroup")]
    public virtual ICollection<Service> Services { get; set; } = new List<Service>();
}
