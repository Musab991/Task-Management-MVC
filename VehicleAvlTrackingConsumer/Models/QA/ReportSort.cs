using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class ReportSort
{
    public Guid Id { get; set; }

    public Guid ReportEngineId { get; set; }

    public string FieldKey { get; set; } = null!;

    public bool IsDescending { get; set; }

    public int SortOrder { get; set; }

    public Guid TenantId { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public virtual ReportEngine ReportEngine { get; set; } = null!;
}
