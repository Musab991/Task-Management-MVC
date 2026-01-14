using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class OperationalPlanDetail
{
    public Guid Id { get; set; }

    public Guid OperationalPlanId { get; set; }

    public int Order { get; set; }

    public string? TagId { get; set; }

    public Guid? BinId { get; set; }

    public double BinWeight { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool IsDeleted { get; set; }

    public Guid TenantId { get; set; }

    public double Length { get; set; }

    public double Area { get; set; }

    public decimal StreetWeightPercentage { get; set; }

    public Guid? ContractServiceMapGeometryId { get; set; }

    public virtual Bin? Bin { get; set; }

    public virtual ContractServiceMapGeometry? ContractServiceMapGeometry { get; set; }

    public virtual OperationalPlan OperationalPlan { get; set; } = null!;
}
