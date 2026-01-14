using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[PrimaryKey("Id", "NotificationTypeId")]
[Index("IsDeleted", Name = "IX_NotificationTypeEntries_IsDeleted")]
[Index("NotificationTypeId", Name = "IX_NotificationTypeEntries_NotificationTypeId")]
public partial class NotificationTypeEntry
{
    [Key]
    public Guid Id { get; set; }

    [Key]
    public Guid NotificationTypeId { get; set; }

    public int Order { get; set; }

    [StringLength(200)]
    public string? StringValue { get; set; }

    public int? IntValue { get; set; }

    public int EntryType { get; set; }

    public int? DdlType { get; set; }

    public bool IsDeleted { get; set; }

    [ForeignKey("NotificationTypeId")]
    [InverseProperty("NotificationTypeEntries")]
    public virtual NotificationType NotificationType { get; set; } = null!;
}
