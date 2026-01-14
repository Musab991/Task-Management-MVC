using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh;

[Index("CreatedDate", Name = "IX_OperationPlanMonthlyFrequencyDays_CreatedDate")]
[Index("IsDeleted", Name = "IX_OperationPlanMonthlyFrequencyDays_IsDeleted")]
[Index("OperationalPlansId", Name = "IX_OperationPlanMonthlyFrequencyDays_OperationalPlansId")]
[Index("TenantId", Name = "IX_OperationPlanMonthlyFrequencyDays_TenantId")]
public partial class OperationPlanMonthlyFrequencyDay
{
    [Key]
    public Guid Id { get; set; }

    public int DayDateInMonth { get; set; }

    public Guid OperationPlanId { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    public Guid? OperationalPlansId { get; set; }

    [ForeignKey("OperationalPlansId")]
    [InverseProperty("OperationPlanMonthlyFrequencyDays")]
    public virtual OperationalPlan? OperationalPlans { get; set; }
}
