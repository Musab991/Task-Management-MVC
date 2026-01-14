using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class NotificationTypeEntry
{
    public Guid Id { get; set; }

    public Guid NotificationTypeId { get; set; }

    public int Order { get; set; }

    public string? StringValue { get; set; }

    public int? IntValue { get; set; }

    public int EntryType { get; set; }

    public int? DdlType { get; set; }

    public bool IsDeleted { get; set; }

    public virtual NotificationType NotificationType { get; set; } = null!;
}
