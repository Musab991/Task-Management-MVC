using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[Table("ContractingCompany_Localizations")]
[Index("CreatedDate", Name = "IX_ContractingCompany_Localizations_CreatedDate")]
[Index("EntityId", Name = "IX_ContractingCompany_Localizations_EntityId")]
[Index("IsDeleted", Name = "IX_ContractingCompany_Localizations_IsDeleted")]
[Index("LanguageLocale", Name = "IX_ContractingCompany_Localizations_LanguageLocale")]
[Index("TenantId", Name = "IX_ContractingCompany_Localizations_TenantId")]
public partial class ContractingCompanyLocalization
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
    [InverseProperty("ContractingCompanyLocalizations")]
    public virtual ContractingCompany Entity { get; set; } = null!;

    [ForeignKey("LanguageLocale")]
    [InverseProperty("ContractingCompanyLocalizations")]
    public virtual SupportedLanguage LanguageLocaleNavigation { get; set; } = null!;
}
