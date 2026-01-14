using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class NotificationType
{
    public Guid Id { get; set; }

    public bool IsDeleted { get; set; }

    public int TypeEnum { get; set; }

    public int MessageDictionaryId { get; set; }

    public int TitleDictionaryId { get; set; }

    public int EditDictionaryId { get; set; }

    public virtual Dictionary EditDictionary { get; set; } = null!;

    public virtual Dictionary MessageDictionary { get; set; } = null!;

    public virtual ICollection<NotificationTypeEntry> NotificationTypeEntries { get; set; } = new List<NotificationTypeEntry>();

    public virtual ICollection<Notification> Notifications { get; set; } = new List<Notification>();

    public virtual Dictionary TitleDictionary { get; set; } = null!;
}
