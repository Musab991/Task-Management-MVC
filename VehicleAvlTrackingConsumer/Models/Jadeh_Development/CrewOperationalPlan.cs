using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[PrimaryKey("CrewId", "OperationalPlansId")]
[Index("CreatedDate", Name = "IX_CrewOperationalPlans_CreatedDate")]
[Index("IsDeleted", Name = "IX_CrewOperationalPlans_IsDeleted")]
[Index("OperationalPlansId", Name = "IX_CrewOperationalPlans_OperationalPlansId")]
[Index("TenantId", Name = "IX_CrewOperationalPlans_TenantId")]
public partial class CrewOperationalPlan
{
    [Key]
    public Guid CrewId { get; set; }

    [Key]
    public Guid OperationalPlansId { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public Guid Id { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public Guid TenantId { get; set; }

    [ForeignKey("CrewId")]
    [InverseProperty("CrewOperationalPlans")]
    public virtual Crew Crew { get; set; } = null!;

    [ForeignKey("OperationalPlansId")]
    [InverseProperty("CrewOperationalPlans")]
    public virtual OperationalPlan OperationalPlans { get; set; } = null!;
}
