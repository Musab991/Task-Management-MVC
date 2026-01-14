using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class ContractServiceMapGeometry
{
    public Guid Id { get; set; }

    public string? GeometryJson { get; set; }

    public string? PropertiesJson { get; set; }

    public Guid ContractId { get; set; }

    public Guid TenantId { get; set; }

    public Guid? BinId { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public string? Tag { get; set; }

    public bool IsDeleted { get; set; }

    public Guid? ContractServiceId { get; set; }

    public int GeoType { get; set; }

    public double? Length { get; set; }

    public double? Area { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ReferenceCode { get; set; }

    public virtual Bin? Bin { get; set; }

    public virtual Contract Contract { get; set; } = null!;

    public virtual ContractService? ContractService { get; set; }

    public virtual ICollection<OperationalPlanDetail> OperationalPlanDetails { get; set; } = new List<OperationalPlanDetail>();

    public virtual ICollection<TripDetail> TripDetails { get; set; } = new List<TripDetail>();
}
