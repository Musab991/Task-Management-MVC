using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class OperationPlanMonthlyFrequencyDay
{
    public Guid Id { get; set; }

    public int DayDateInMonth { get; set; }

    public Guid OperationPlanId { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    public Guid? OperationalPlansId { get; set; }

    public virtual OperationalPlan? OperationalPlans { get; set; }
}
