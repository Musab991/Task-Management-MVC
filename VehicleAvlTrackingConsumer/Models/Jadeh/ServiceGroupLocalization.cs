using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh;

[Table("ServiceGroup_Localizations")]
[Index("CreatedDate", Name = "IX_ServiceGroup_Localizations_CreatedDate")]
[Index("IsDeleted", Name = "IX_ServiceGroup_Localizations_IsDeleted")]
[Index("TenantId", Name = "IX_ServiceGroup_Localizations_TenantId")]
public partial class ServiceGroupLocalization
{
    [Key]
    public int Id { get; set; }

    public Guid EntityId { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string LanguageLocale { get; set; } = null!;

    [StringLength(200)]
    public string? Description { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public Guid TenantId { get; set; }

    [ForeignKey("EntityId")]
    [InverseProperty("ServiceGroupLocalizations")]
    public virtual ServiceGroup Entity { get; set; } = null!;

    [ForeignKey("LanguageLocale")]
    [InverseProperty("ServiceGroupLocalizations")]
    public virtual SupportedLanguage LanguageLocaleNavigation { get; set; } = null!;
}
