using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class Bin
{
    public Guid Id { get; set; }

    public Guid ContractingCompanyId { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    public Guid BinTypeId { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public string? TagId { get; set; }

    public string? Number { get; set; }

    public Guid? ContractTypeId { get; set; }

    public int? TypeLookupId { get; set; }

    public virtual ICollection<BinGroupMember> BinGroupMembers { get; set; } = new List<BinGroupMember>();

    public virtual BinType BinType { get; set; } = null!;

    public virtual ICollection<ContractServiceMapGeometry> ContractServiceMapGeometries { get; set; } = new List<ContractServiceMapGeometry>();

    public virtual ContractType? ContractType { get; set; }

    public virtual ContractingCompany ContractingCompany { get; set; } = null!;

    public virtual ICollection<OperationalPlanDetail> OperationalPlanDetails { get; set; } = new List<OperationalPlanDetail>();

    public virtual ICollection<TripDetail> TripDetails { get; set; } = new List<TripDetail>();

    public virtual Lookup? TypeLookup { get; set; }
}
