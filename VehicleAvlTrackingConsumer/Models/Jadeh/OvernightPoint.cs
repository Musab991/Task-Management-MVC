using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh;

[Index("ContractTypeId", Name = "IX_OvernightPoints_ContractTypeId")]
[Index("ContractingCompanyId", Name = "IX_OvernightPoints_ContractingCompanyId")]
[Index("CreatedDate", Name = "IX_OvernightPoints_CreatedDate")]
[Index("IsDeleted", Name = "IX_OvernightPoints_IsDeleted")]
[Index("TenantId", Name = "IX_OvernightPoints_TenantId")]
public partial class OvernightPoint
{
    [Key]
    public Guid Id { get; set; }

    public Guid ContractingCompanyId { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    public Guid? ContractTypeId { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    [ForeignKey("ContractTypeId")]
    [InverseProperty("OvernightPoints")]
    public virtual ContractType? ContractType { get; set; }

    [ForeignKey("ContractingCompanyId")]
    [InverseProperty("OvernightPoints")]
    public virtual ContractingCompany ContractingCompany { get; set; } = null!;

    [InverseProperty("OvernightPoint")]
    public virtual ICollection<OperationalPlan> OperationalPlans { get; set; } = new List<OperationalPlan>();

    [InverseProperty("Entity")]
    public virtual ICollection<OvernightPointLocalization> OvernightPointLocalizations { get; set; } = new List<OvernightPointLocalization>();

    [InverseProperty("OvernightPoint")]
    public virtual ICollection<Trip> Trips { get; set; } = new List<Trip>();
}
