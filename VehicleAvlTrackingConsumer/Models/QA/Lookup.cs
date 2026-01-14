using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class Lookup
{
    public int Id { get; set; }

    public int DictionaryId { get; set; }

    public int CategoryId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool IsDeleted { get; set; }

    public Guid TenantId { get; set; }

    public virtual ICollection<Bin> Bins { get; set; } = new List<Bin>();

    public virtual LookupCategory Category { get; set; } = null!;

    public virtual Dictionary Dictionary { get; set; } = null!;

    public virtual ICollection<TripDetailsProcessingSummary> TripDetailsProcessingSummaryManualLiftReasonLookups { get; set; } = new List<TripDetailsProcessingSummary>();

    public virtual ICollection<TripDetailsProcessingSummary> TripDetailsProcessingSummaryStatusLookups { get; set; } = new List<TripDetailsProcessingSummary>();
}
