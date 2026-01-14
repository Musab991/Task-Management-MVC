using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[Index("CategoryId", Name = "IX_DisposalPoints_CategoryId")]
[Index("ContractTypeId", Name = "IX_DisposalPoints_ContractTypeId")]
[Index("ContractingCompanyId", Name = "IX_DisposalPoints_ContractingCompanyId")]
[Index("CreatedDate", Name = "IX_DisposalPoints_CreatedDate")]
[Index("IsDeleted", Name = "IX_DisposalPoints_IsDeleted")]
[Index("TenantId", Name = "IX_DisposalPoints_TenantId")]
public partial class DisposalPoint
{
    [Key]
    public Guid Id { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    public Guid? ContractingCompanyId { get; set; }

    public Guid? ContractTypeId { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public int? CategoryId { get; set; }

    public string? GeometryJson { get; set; }

    public string? PropertiesJson { get; set; }

    public long TotalCapacity { get; set; }

    [ForeignKey("CategoryId")]
    [InverseProperty("DisposalPoints")]
    public virtual DisposalPointCategory? Category { get; set; }

    [ForeignKey("ContractTypeId")]
    [InverseProperty("DisposalPoints")]
    public virtual ContractType? ContractType { get; set; }

    [ForeignKey("ContractingCompanyId")]
    [InverseProperty("DisposalPoints")]
    public virtual ContractingCompany? ContractingCompany { get; set; }

    [InverseProperty("Entity")]
    public virtual ICollection<DisposalPointLocalization> DisposalPointLocalizations { get; set; } = new List<DisposalPointLocalization>();

    [InverseProperty("DisposalPoint")]
    public virtual ICollection<OperationalPlan> OperationalPlans { get; set; } = new List<OperationalPlan>();

    [InverseProperty("DisposalPoint")]
    public virtual ICollection<Trip> Trips { get; set; } = new List<Trip>();
}
