using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[Table("Notification")]
[Index("CreatedDate", Name = "IX_Notification_CreatedDate")]
[Index("IsDeleted", Name = "IX_Notification_IsDeleted")]
[Index("Locale", Name = "IX_Notification_Locale")]
[Index("NotificationTypeId", Name = "IX_Notification_NotificationTypeId")]
[Index("TenantId", Name = "IX_Notification_TenantId")]
public partial class Notification
{
    [Key]
    public Guid Id { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public bool IsDeleted { get; set; }

    public Guid TenantId { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string Locale { get; set; } = null!;

    public Guid ToUserId { get; set; }

    public Guid FromUserId { get; set; }

    [StringLength(200)]
    public string? Subject { get; set; }

    [StringLength(200)]
    public string? Message { get; set; }

    public Guid NotificationTypeId { get; set; }

    public bool IsRead { get; set; }

    [ForeignKey("Locale")]
    [InverseProperty("Notifications")]
    public virtual SupportedLanguage LocaleNavigation { get; set; } = null!;

    [ForeignKey("NotificationTypeId")]
    [InverseProperty("Notifications")]
    public virtual NotificationType NotificationType { get; set; } = null!;
}
