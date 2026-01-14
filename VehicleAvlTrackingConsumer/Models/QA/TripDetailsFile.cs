using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class TripDetailsFile
{
    public Guid Id { get; set; }

    public string? FileName { get; set; }

    public string? FilePath { get; set; }

    public Guid TripDetailsId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool IsDeleted { get; set; }

    public Guid TenantId { get; set; }

    public virtual TripDetail TripDetails { get; set; } = null!;
}
