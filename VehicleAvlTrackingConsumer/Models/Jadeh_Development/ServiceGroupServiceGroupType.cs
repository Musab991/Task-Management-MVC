using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[PrimaryKey("ServiceGroupId", "ServiceGroupTypeId")]
[Table("ServiceGroup_ServiceGroupType")]
[Index("CreatedDate", Name = "IX_ServiceGroup_ServiceGroupType_CreatedDate")]
[Index("IsDeleted", Name = "IX_ServiceGroup_ServiceGroupType_IsDeleted")]
[Index("ServiceGroupTypeId", Name = "IX_ServiceGroup_ServiceGroupType_ServiceGroupTypeId")]
[Index("TenantId", Name = "IX_ServiceGroup_ServiceGroupType_TenantId")]
public partial class ServiceGroupServiceGroupType
{
    [Key]
    public Guid ServiceGroupId { get; set; }

    [Key]
    public Guid ServiceGroupTypeId { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    public bool IsDeleted { get; set; }

    public Guid Id { get; set; }

    [ForeignKey("ServiceGroupId")]
    [InverseProperty("ServiceGroupServiceGroupTypes")]
    public virtual ServiceGroup ServiceGroup { get; set; } = null!;

    [ForeignKey("ServiceGroupTypeId")]
    [InverseProperty("ServiceGroupServiceGroupTypes")]
    public virtual ServiceGroupType ServiceGroupType { get; set; } = null!;
}
