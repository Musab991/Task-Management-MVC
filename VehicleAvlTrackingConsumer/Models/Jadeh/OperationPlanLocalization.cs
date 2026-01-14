using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh;

[Table("OperationPlan_Localizations")]
[Index("CreatedDate", Name = "IX_OperationPlan_Localizations_CreatedDate")]
[Index("EntityId", Name = "IX_OperationPlan_Localizations_EntityId")]
[Index("IsDeleted", Name = "IX_OperationPlan_Localizations_IsDeleted")]
[Index("LanguageLocale", Name = "IX_OperationPlan_Localizations_LanguageLocale")]
[Index("TenantId", Name = "IX_OperationPlan_Localizations_TenantId")]
public partial class OperationPlanLocalization
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
    [InverseProperty("OperationPlanLocalizations")]
    public virtual OperationalPlan Entity { get; set; } = null!;

    [ForeignKey("LanguageLocale")]
    [InverseProperty("OperationPlanLocalizations")]
    public virtual SupportedLanguage LanguageLocaleNavigation { get; set; } = null!;
}
