using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh;

[Table("LicenseType_Localizations")]
[Index("CreatedDate", Name = "IX_LicenseType_Localizations_CreatedDate")]
[Index("EntityId", Name = "IX_LicenseType_Localizations_EntityId")]
[Index("IsDeleted", Name = "IX_LicenseType_Localizations_IsDeleted")]
[Index("LanguageLocale", Name = "IX_LicenseType_Localizations_LanguageLocale")]
[Index("TenantId", Name = "IX_LicenseType_Localizations_TenantId")]
public partial class LicenseTypeLocalization
{
    public Guid EntityId { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string LanguageLocale { get; set; } = null!;

    [StringLength(200)]
    public string? Description { get; set; }

    [Key]
    public int Id { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public Guid TenantId { get; set; }

    [ForeignKey("EntityId")]
    [InverseProperty("LicenseTypeLocalizations")]
    public virtual LicenseType Entity { get; set; } = null!;

    [ForeignKey("LanguageLocale")]
    [InverseProperty("LicenseTypeLocalizations")]
    public virtual SupportedLanguage LanguageLocaleNavigation { get; set; } = null!;
}
