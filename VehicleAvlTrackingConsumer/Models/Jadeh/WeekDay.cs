using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh;

[Index("CreatedDate", Name = "IX_WeekDays_CreatedDate")]
[Index("IsDeleted", Name = "IX_WeekDays_IsDeleted")]
[Index("TenantId", Name = "IX_WeekDays_TenantId")]
public partial class WeekDay
{
    [Key]
    public Guid Id { get; set; }

    public int Day { get; set; }

    [StringLength(200)]
    public string? Name { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    [InverseProperty("WeekDays")]
    public virtual ICollection<OperationalPlansDay> OperationalPlansDays { get; set; } = new List<OperationalPlansDay>();

    [InverseProperty("Entity")]
    public virtual ICollection<WeekDaysLocalization> WeekDaysLocalizations { get; set; } = new List<WeekDaysLocalization>();
}
