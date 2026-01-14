using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class Alarm
{
    public Guid Id { get; set; }

    public Guid ContractingCompanyId { get; set; }

    public Guid TripId { get; set; }

    public Guid DriverId { get; set; }

    public Guid VehicleId { get; set; }

    public int AlarmsStatusTypeId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool IsDeleted { get; set; }

    public Guid TenantId { get; set; }

    public int NotificationTypeId { get; set; }

    public virtual AlarmsStatusType AlarmsStatusType { get; set; } = null!;
}
