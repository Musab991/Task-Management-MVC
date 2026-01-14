using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class DisposalPointLocalization
{
    public Guid EntityId { get; set; }

    public string LanguageLocale { get; set; } = null!;

    public string? Description { get; set; }

    public int Id { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public bool IsDeleted { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public Guid TenantId { get; set; }

    public virtual DisposalPoint Entity { get; set; } = null!;

    public virtual SupportedLanguage LanguageLocaleNavigation { get; set; } = null!;
}
