using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[Table("NotificationType")]
[Index("EditDictionaryId", Name = "IX_NotificationType_EditDictionaryId")]
[Index("IsDeleted", Name = "IX_NotificationType_IsDeleted")]
[Index("MessageDictionaryId", Name = "IX_NotificationType_MessageDictionaryId")]
[Index("TitleDictionaryId", Name = "IX_NotificationType_TitleDictionaryId")]
public partial class NotificationType
{
    [Key]
    public Guid Id { get; set; }

    public bool IsDeleted { get; set; }

    public int TypeEnum { get; set; }

    public int MessageDictionaryId { get; set; }

    public int TitleDictionaryId { get; set; }

    public int EditDictionaryId { get; set; }

    [ForeignKey("EditDictionaryId")]
    [InverseProperty("NotificationTypeEditDictionaries")]
    public virtual Dictionary EditDictionary { get; set; } = null!;

    [ForeignKey("MessageDictionaryId")]
    [InverseProperty("NotificationTypeMessageDictionaries")]
    public virtual Dictionary MessageDictionary { get; set; } = null!;

    [InverseProperty("NotificationType")]
    public virtual ICollection<NotificationTypeEntry> NotificationTypeEntries { get; set; } = new List<NotificationTypeEntry>();

    [InverseProperty("NotificationType")]
    public virtual ICollection<Notification> Notifications { get; set; } = new List<Notification>();

    [ForeignKey("TitleDictionaryId")]
    [InverseProperty("NotificationTypeTitleDictionaries")]
    public virtual Dictionary TitleDictionary { get; set; } = null!;
}
