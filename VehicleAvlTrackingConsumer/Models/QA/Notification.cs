using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class Notification
{
    public Guid Id { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool IsDeleted { get; set; }

    public Guid TenantId { get; set; }

    public string Locale { get; set; } = null!;

    public Guid ToUserId { get; set; }

    public Guid FromUserId { get; set; }

    public string? Subject { get; set; }

    public string? Message { get; set; }

    public Guid NotificationTypeId { get; set; }

    public bool IsRead { get; set; }

    public virtual SupportedLanguage LocaleNavigation { get; set; } = null!;

    public virtual NotificationType NotificationType { get; set; } = null!;
}
