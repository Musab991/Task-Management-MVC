using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

public partial class SupportedLanguage
{
    [Key]
    [StringLength(2)]
    [Unicode(false)]
    public string Language { get; set; } = null!;

    [StringLength(225)]
    public string Name { get; set; } = null!;

    public bool Active { get; set; }

    [StringLength(3)]
    public string? Direction { get; set; }

    [InverseProperty("LanguageLocaleNavigation")]
    public virtual ICollection<ApplicationUserLocalization> ApplicationUserLocalizations { get; set; } = new List<ApplicationUserLocalization>();

    [InverseProperty("LanguageLocaleNavigation")]
    public virtual ICollection<ContractLocalization> ContractLocalizations { get; set; } = new List<ContractLocalization>();

    [InverseProperty("LanguageLocaleNavigation")]
    public virtual ICollection<ContractingCompanyLocalization> ContractingCompanyLocalizations { get; set; } = new List<ContractingCompanyLocalization>();

    [InverseProperty("LanguageLocaleNavigation")]
    public virtual ICollection<CrewLocalization> CrewLocalizations { get; set; } = new List<CrewLocalization>();

    [InverseProperty("LanguageLocaleNavigation")]
    public virtual ICollection<DictionaryLocaization> DictionaryLocaizations { get; set; } = new List<DictionaryLocaization>();

    [InverseProperty("LanguageLocaleNavigation")]
    public virtual ICollection<DisposalPointLocalization> DisposalPointLocalizations { get; set; } = new List<DisposalPointLocalization>();

    [InverseProperty("LanguageLocaleNavigation")]
    public virtual ICollection<LicenseTypeLocalization> LicenseTypeLocalizations { get; set; } = new List<LicenseTypeLocalization>();

    [InverseProperty("LocaleNavigation")]
    public virtual ICollection<Notification> Notifications { get; set; } = new List<Notification>();

    [InverseProperty("LanguageLocaleNavigation")]
    public virtual ICollection<OperationPlanLocalization> OperationPlanLocalizations { get; set; } = new List<OperationPlanLocalization>();

    [InverseProperty("LanguageLocaleNavigation")]
    public virtual ICollection<OvernightPointLocalization> OvernightPointLocalizations { get; set; } = new List<OvernightPointLocalization>();

    [InverseProperty("LanguageLocaleNavigation")]
    public virtual ICollection<RoleLocalization> RoleLocalizations { get; set; } = new List<RoleLocalization>();

    [InverseProperty("LanguageLocaleNavigation")]
    public virtual ICollection<ServiceGroupLocalization> ServiceGroupLocalizations { get; set; } = new List<ServiceGroupLocalization>();

    [InverseProperty("LanguageLocaleNavigation")]
    public virtual ICollection<ServiceLocalization> ServiceLocalizations { get; set; } = new List<ServiceLocalization>();

    [InverseProperty("LanguageLocaleNavigation")]
    public virtual ICollection<TripLocalizationLocalization> TripLocalizationLocalizations { get; set; } = new List<TripLocalizationLocalization>();

    [InverseProperty("LanguageLocaleNavigation")]
    public virtual ICollection<WeekDaysLocalization> WeekDaysLocalizations { get; set; } = new List<WeekDaysLocalization>();

    [InverseProperty("LanguageLocaleNavigation")]
    public virtual ICollection<ZoneTypeLocalization> ZoneTypeLocalizations { get; set; } = new List<ZoneTypeLocalization>();

    [InverseProperty("LanguageLocaleNavigation")]
    public virtual ICollection<ZonesLocalization> ZonesLocalizations { get; set; } = new List<ZonesLocalization>();
}
