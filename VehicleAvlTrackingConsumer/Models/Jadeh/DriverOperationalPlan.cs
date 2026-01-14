using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh;

[Table("DriverOperationalPlan")]
[Index("CreatedDate", Name = "IX_DriverOperationalPlan_CreatedDate")]
[Index("DriverId", Name = "IX_DriverOperationalPlan_DriverId")]
[Index("IsDeleted", Name = "IX_DriverOperationalPlan_IsDeleted")]
[Index("OperationalPlansId", Name = "IX_DriverOperationalPlan_OperationalPlansId")]
[Index("TenantId", Name = "IX_DriverOperationalPlan_TenantId")]
public partial class DriverOperationalPlan
{
    [Key]
    public Guid Id { get; set; }

    public Guid DriverId { get; set; }

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

    [ForeignKey("DriverId")]
    [InverseProperty("DriverOperationalPlans")]
    public virtual Crew Driver { get; set; } = null!;

    [ForeignKey("OperationalPlansId")]
    [InverseProperty("DriverOperationalPlans")]
    public virtual OperationalPlan OperationalPlans { get; set; } = null!;
}
