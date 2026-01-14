using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[PrimaryKey("OperationalPlansId", "WeekDaysId")]
[Table("OperationalPlansDay")]
[Index("CreatedDate", Name = "IX_OperationalPlansDay_CreatedDate")]
[Index("IsDeleted", Name = "IX_OperationalPlansDay_IsDeleted")]
[Index("TenantId", Name = "IX_OperationalPlansDay_TenantId")]
[Index("WeekDaysId", Name = "IX_OperationalPlansDay_WeekDaysId")]
public partial class OperationalPlansDay
{
    [Key]
    public Guid OperationalPlansId { get; set; }

    [Key]
    public Guid WeekDaysId { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    [ForeignKey("OperationalPlansId")]
    [InverseProperty("OperationalPlansDays")]
    public virtual OperationalPlan OperationalPlans { get; set; } = null!;

    [ForeignKey("WeekDaysId")]
    [InverseProperty("OperationalPlansDays")]
    public virtual WeekDay WeekDays { get; set; } = null!;
}
