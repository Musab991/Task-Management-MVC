using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh;

[Table("DynamicServiceProcessLog")]
[Index("ContractId", Name = "IX_DynamicServiceProcessLog_ContractId")]
[Index("ContractServiceId", Name = "IX_DynamicServiceProcessLog_ContractServiceId")]
[Index("CreatedDate", Name = "IX_DynamicServiceProcessLog_CreatedDate")]
[Index("LogDateTime", Name = "IX_DynamicServiceProcessLog_LogDateTime")]
[Index("OperationalPlanId", Name = "IX_DynamicServiceProcessLog_OperationalPlanId")]
[Index("ServiceGroupId", Name = "IX_DynamicServiceProcessLog_ServiceGroupId")]
[Index("TenantId", Name = "IX_DynamicServiceProcessLog_TenantId")]
public partial class DynamicServiceProcessLog
{
    [Key]
    public Guid Id { get; set; }

    public Guid? OperationalPlanId { get; set; }

    public Guid? ContractId { get; set; }

    public Guid? ContractServiceId { get; set; }

    public Guid? ServiceGroupId { get; set; }

    public int ContractType { get; set; }

    public int GroupServiceType { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? OperationalPlanCompletionPercentage { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? ServiceCompletionPercentage { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? ServiceGroupCompletionPercentage { get; set; }

    [Column(TypeName = "decimal(18, 6)")]
    public decimal? ContractCompletionPercentage { get; set; }

    public DateTime LogDateTime { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateOnly CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    public Guid ContractingCompanyId { get; set; }

    public string? OperationalPlanName { get; set; }

    public string? ServiceGroupName { get; set; }

    public string? ContractName { get; set; }
}
