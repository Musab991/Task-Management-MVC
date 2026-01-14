using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class DynamicServiceProcessLog
{
    public Guid Id { get; set; }

    public Guid? OperationalPlanId { get; set; }

    public Guid? ContractId { get; set; }

    public Guid? ContractServiceId { get; set; }

    public Guid? ServiceGroupId { get; set; }

    public int ContractType { get; set; }

    public int GroupServiceType { get; set; }

    public decimal? OperationalPlanCompletionPercentage { get; set; }

    public decimal? ServiceCompletionPercentage { get; set; }

    public decimal? ServiceGroupCompletionPercentage { get; set; }

    public decimal? ContractCompletionPercentage { get; set; }

    public DateTime LogDateTime { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateOnly CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    public Guid ContractingCompanyId { get; set; }

    public string? OperationalPlanName { get; set; }

    public string? ServiceGroupName { get; set; }

    public string? ContractName { get; set; }
}
