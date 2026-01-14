using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[Index("BinId", Name = "IX_OperationalPlanDetails_BinId")]
[Index("ContractServiceMapGeometryId", Name = "IX_OperationalPlanDetails_ContractServiceMapGeometryId")]
[Index("CreatedDate", Name = "IX_OperationalPlanDetails_CreatedDate")]
[Index("IsDeleted", Name = "IX_OperationalPlanDetails_IsDeleted")]
[Index("OperationalPlanId", Name = "IX_OperationalPlanDetails_OperationalPlanId")]
[Index("TenantId", Name = "IX_OperationalPlanDetails_TenantId")]
public partial class OperationalPlanDetail
{
    [Key]
    public Guid Id { get; set; }

    public Guid OperationalPlanId { get; set; }

    public int Order { get; set; }

    [StringLength(200)]
    public string? TagId { get; set; }

    public Guid? BinId { get; set; }

    public double BinWeight { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public bool IsDeleted { get; set; }

    public Guid TenantId { get; set; }

    public double Length { get; set; }

    public double Area { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal StreetWeightPercentage { get; set; }

    public Guid? ContractServiceMapGeometryId { get; set; }

    [ForeignKey("BinId")]
    [InverseProperty("OperationalPlanDetails")]
    public virtual Bin? Bin { get; set; }

    [ForeignKey("ContractServiceMapGeometryId")]
    [InverseProperty("OperationalPlanDetails")]
    public virtual ContractServiceMapGeometry? ContractServiceMapGeometry { get; set; }

    [ForeignKey("OperationalPlanId")]
    [InverseProperty("OperationalPlanDetails")]
    public virtual OperationalPlan OperationalPlan { get; set; } = null!;
}
