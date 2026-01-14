using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class Dictionary
{
    public int Id { get; set; }

    public virtual ICollection<AlarmsStatusType> AlarmsStatusTypes { get; set; } = new List<AlarmsStatusType>();

    public virtual ICollection<BinType> BinTypes { get; set; } = new List<BinType>();

    public virtual ICollection<ContractType> ContractTypes { get; set; } = new List<ContractType>();

    public virtual ICollection<DictionaryLocaization> DictionaryLocaizations { get; set; } = new List<DictionaryLocaization>();

    public virtual ICollection<DisposalPointCategory> DisposalPointCategories { get; set; } = new List<DisposalPointCategory>();

    public virtual ICollection<Lookup> Lookups { get; set; } = new List<Lookup>();

    public virtual ICollection<NotificationType> NotificationTypeEditDictionaries { get; set; } = new List<NotificationType>();

    public virtual ICollection<NotificationType> NotificationTypeMessageDictionaries { get; set; } = new List<NotificationType>();

    public virtual ICollection<NotificationType> NotificationTypeTitleDictionaries { get; set; } = new List<NotificationType>();

    public virtual ICollection<PrivilegeGroup> PrivilegeGroups { get; set; } = new List<PrivilegeGroup>();

    public virtual ICollection<Privilege> Privileges { get; set; } = new List<Privilege>();

    public virtual ICollection<ServiceGroupType> ServiceGroupTypes { get; set; } = new List<ServiceGroupType>();
}
