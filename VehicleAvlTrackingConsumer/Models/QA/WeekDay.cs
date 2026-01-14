using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class WeekDay
{
    public Guid Id { get; set; }

    public int Day { get; set; }

    public string? Name { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    public virtual ICollection<OperationalPlansDay> OperationalPlansDays { get; set; } = new List<OperationalPlansDay>();

    public virtual ICollection<WeekDaysLocalization> WeekDaysLocalizations { get; set; } = new List<WeekDaysLocalization>();
}
