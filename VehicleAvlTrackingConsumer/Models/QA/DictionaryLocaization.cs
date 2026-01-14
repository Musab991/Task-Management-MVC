using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class DictionaryLocaization
{
    public int Id { get; set; }

    public string LanguageLocale { get; set; } = null!;

    public string Description { get; set; } = null!;

    public virtual Dictionary IdNavigation { get; set; } = null!;

    public virtual SupportedLanguage LanguageLocaleNavigation { get; set; } = null!;
}
