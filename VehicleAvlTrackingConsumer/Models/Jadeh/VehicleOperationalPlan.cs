using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh;

[Table("VehicleOperationalPlan")]
[Index("CreatedDate", Name = "IX_VehicleOperationalPlan_CreatedDate")]
[Index("IsDeleted", Name = "IX_VehicleOperationalPlan_IsDeleted")]
[Index("OperationalPlansId", Name = "IX_VehicleOperationalPlan_OperationalPlansId")]
[Index("TenantId", Name = "IX_VehicleOperationalPlan_TenantId")]
[Index("VehicleId", Name = "IX_VehicleOperationalPlan_VehicleId")]
public partial class VehicleOperationalPlan
{
    [Key]
    public Guid Id { get; set; }

    public Guid VehicleId { get; set; }

    public Guid OperationalPlansId { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    public bool IsMain { get; set; }

    [ForeignKey("OperationalPlansId")]
    [InverseProperty("VehicleOperationalPlans")]
    public virtual OperationalPlan OperationalPlans { get; set; } = null!;

    [ForeignKey("VehicleId")]
    [InverseProperty("VehicleOperationalPlans")]
    public virtual Vehicle Vehicle { get; set; } = null!;
}
