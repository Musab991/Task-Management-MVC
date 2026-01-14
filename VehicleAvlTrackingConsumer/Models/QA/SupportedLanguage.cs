using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class SupportedLanguage
{
    public string Language { get; set; } = null!;

    public string Name { get; set; } = null!;

    public bool Active { get; set; }

    public string? Direction { get; set; }

    public virtual ICollection<ApplicationUserLocalization> ApplicationUserLocalizations { get; set; } = new List<ApplicationUserLocalization>();

    public virtual ICollection<ContractLocalization> ContractLocalizations { get; set; } = new List<ContractLocalization>();

    public virtual ICollection<ContractingCompanyLocalization> ContractingCompanyLocalizations { get; set; } = new List<ContractingCompanyLocalization>();

    public virtual ICollection<CrewLocalization> CrewLocalizations { get; set; } = new List<CrewLocalization>();

    public virtual ICollection<DictionaryLocaization> DictionaryLocaizations { get; set; } = new List<DictionaryLocaization>();

    public virtual ICollection<DisposalPointLocalization> DisposalPointLocalizations { get; set; } = new List<DisposalPointLocalization>();

    public virtual ICollection<LicenseTypeLocalization> LicenseTypeLocalizations { get; set; } = new List<LicenseTypeLocalization>();

    public virtual ICollection<Notification> Notifications { get; set; } = new List<Notification>();

    public virtual ICollection<OperationPlanLocalization> OperationPlanLocalizations { get; set; } = new List<OperationPlanLocalization>();

    public virtual ICollection<OvernightPointLocalization> OvernightPointLocalizations { get; set; } = new List<OvernightPointLocalization>();

    public virtual ICollection<RoleLocalization> RoleLocalizations { get; set; } = new List<RoleLocalization>();

    public virtual ICollection<ServiceGroupLocalization> ServiceGroupLocalizations { get; set; } = new List<ServiceGroupLocalization>();

    public virtual ICollection<ServiceLocalization> ServiceLocalizations { get; set; } = new List<ServiceLocalization>();

    public virtual ICollection<TripLocalizationLocalization> TripLocalizationLocalizations { get; set; } = new List<TripLocalizationLocalization>();

    public virtual ICollection<WeekDaysLocalization> WeekDaysLocalizations { get; set; } = new List<WeekDaysLocalization>();

    public virtual ICollection<ZoneTypeLocalization> ZoneTypeLocalizations { get; set; } = new List<ZoneTypeLocalization>();

    public virtual ICollection<ZonesLocalization> ZonesLocalizations { get; set; } = new List<ZonesLocalization>();
}
