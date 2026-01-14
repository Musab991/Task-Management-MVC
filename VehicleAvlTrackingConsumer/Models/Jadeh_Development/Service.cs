using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[Index("CreatedDate", Name = "IX_Services_CreatedDate")]
[Index("IsDeleted", Name = "IX_Services_IsDeleted")]
[Index("ServiceGroupId", Name = "IX_Services_ServiceGroupId")]
[Index("TenantId", Name = "IX_Services_TenantId")]
public partial class Service
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(255)]
    public string Name { get; set; } = null!;

    public Guid ServiceGroupId { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    public bool IsDeleted { get; set; }

    public int GroupType { get; set; }

    public int Type { get; set; }

    public Guid ServiceUiConfigurationId { get; set; }

    public double WeightInGroup { get; set; }

    [InverseProperty("Service")]
    public virtual ICollection<ContractService> ContractServices { get; set; } = new List<ContractService>();

    [InverseProperty("Service")]
    public virtual ICollection<ServiceCrewType> ServiceCrewTypes { get; set; } = new List<ServiceCrewType>();

    [InverseProperty("Service")]
    public virtual ICollection<ServiceGeometryType> ServiceGeometryTypes { get; set; } = new List<ServiceGeometryType>();

    [ForeignKey("ServiceGroupId")]
    [InverseProperty("Services")]
    public virtual ServiceGroup ServiceGroup { get; set; } = null!;

    [InverseProperty("Entity")]
    public virtual ICollection<ServiceLocalization> ServiceLocalizations { get; set; } = new List<ServiceLocalization>();

    [InverseProperty("Service")]
    public virtual ServiceUiConfiguration? ServiceUiConfiguration { get; set; }

    [InverseProperty("Service")]
    public virtual ICollection<ServiceVehicleType> ServiceVehicleTypes { get; set; } = new List<ServiceVehicleType>();
}
