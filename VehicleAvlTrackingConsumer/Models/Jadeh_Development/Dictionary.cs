using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[Table("Dictionary")]
public partial class Dictionary
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [InverseProperty("Dictionary")]
    public virtual ICollection<AlarmsStatusType> AlarmsStatusTypes { get; set; } = new List<AlarmsStatusType>();

    [InverseProperty("Dictionary")]
    public virtual ICollection<BinType> BinTypes { get; set; } = new List<BinType>();

    [InverseProperty("Dictionary")]
    public virtual ICollection<ContractType> ContractTypes { get; set; } = new List<ContractType>();

    [InverseProperty("IdNavigation")]
    public virtual ICollection<DictionaryLocaization> DictionaryLocaizations { get; set; } = new List<DictionaryLocaization>();

    [InverseProperty("Dictionary")]
    public virtual ICollection<DisposalPointCategory> DisposalPointCategories { get; set; } = new List<DisposalPointCategory>();

    [InverseProperty("Dictionary")]
    public virtual ICollection<Lookup> Lookups { get; set; } = new List<Lookup>();

    [InverseProperty("EditDictionary")]
    public virtual ICollection<NotificationType> NotificationTypeEditDictionaries { get; set; } = new List<NotificationType>();

    [InverseProperty("MessageDictionary")]
    public virtual ICollection<NotificationType> NotificationTypeMessageDictionaries { get; set; } = new List<NotificationType>();

    [InverseProperty("TitleDictionary")]
    public virtual ICollection<NotificationType> NotificationTypeTitleDictionaries { get; set; } = new List<NotificationType>();

    [InverseProperty("Dictionary")]
    public virtual ICollection<ServiceGroupType> ServiceGroupTypes { get; set; } = new List<ServiceGroupType>();
}
