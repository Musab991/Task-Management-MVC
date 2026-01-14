using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class TripDetail
{
    public Guid Id { get; set; }

    public Guid TripId { get; set; }

    public int? CompletionType { get; set; }

    public string? TagId { get; set; }

    public double ActualWeight { get; set; }

    public int Order { get; set; }

    public Guid? BinId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool IsDeleted { get; set; }

    public Guid TenantId { get; set; }

    public decimal StreetWeightPercentage { get; set; }

    public double StreetLength { get; set; }

    public byte[]? TagHash { get; set; }

    public string? ReferenceCode { get; set; }

    public Guid? ContractServiceMapGeometryId { get; set; }

    public virtual Bin? Bin { get; set; }

    public virtual ContractServiceMapGeometry? ContractServiceMapGeometry { get; set; }

    public virtual Trip Trip { get; set; } = null!;

    public virtual ICollection<TripDetailsFile> TripDetailsFiles { get; set; } = new List<TripDetailsFile>();

    public virtual TripDetailsProcessingSummary? TripDetailsProcessingSummary { get; set; }
}
