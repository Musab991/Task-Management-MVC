using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[PrimaryKey("Id", "LanguageLocale")]
[Table("DictionaryLocaization")]
[Index("LanguageLocale", Name = "IX_DictionaryLocaization_LanguageLocale")]
public partial class DictionaryLocaization
{
    [Key]
    public int Id { get; set; }

    [Key]
    [StringLength(2)]
    [Unicode(false)]
    public string LanguageLocale { get; set; } = null!;

    public string Description { get; set; } = null!;

    [ForeignKey("Id")]
    [InverseProperty("DictionaryLocaizations")]
    public virtual Dictionary IdNavigation { get; set; } = null!;

    [ForeignKey("LanguageLocale")]
    [InverseProperty("DictionaryLocaizations")]
    public virtual SupportedLanguage LanguageLocaleNavigation { get; set; } = null!;
}
