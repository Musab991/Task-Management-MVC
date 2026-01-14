using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[Index("BinTypeId", Name = "IX_Bins_BinTypeId")]
[Index("ContractTypeId", Name = "IX_Bins_ContractTypeId")]
[Index("ContractingCompanyId", Name = "IX_Bins_ContractingCompanyId")]
[Index("CreatedDate", Name = "IX_Bins_CreatedDate")]
[Index("IsDeleted", Name = "IX_Bins_IsDeleted")]
[Index("TenantId", Name = "IX_Bins_TenantId")]
[Index("TypeLookupId", Name = "IX_Bins_TypeLookupId")]
public partial class Bin
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

    public Guid BinTypeId { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    [StringLength(200)]
    public string? TagId { get; set; }

    [StringLength(200)]
    public string? Number { get; set; }

    public Guid? ContractTypeId { get; set; }

    public int? TypeLookupId { get; set; }

    [InverseProperty("Bin")]
    public virtual ICollection<BinGroupMember> BinGroupMembers { get; set; } = new List<BinGroupMember>();

    [ForeignKey("BinTypeId")]
    [InverseProperty("Bins")]
    public virtual BinType BinType { get; set; } = null!;

    [InverseProperty("Bin")]
    public virtual ICollection<ContractServiceMapGeometry> ContractServiceMapGeometries { get; set; } = new List<ContractServiceMapGeometry>();

    [ForeignKey("ContractTypeId")]
    [InverseProperty("Bins")]
    public virtual ContractType? ContractType { get; set; }

    [ForeignKey("ContractingCompanyId")]
    [InverseProperty("Bins")]
    public virtual ContractingCompany ContractingCompany { get; set; } = null!;

    [InverseProperty("Bin")]
    public virtual ICollection<OperationalPlanDetail> OperationalPlanDetails { get; set; } = new List<OperationalPlanDetail>();

    [InverseProperty("Bin")]
    public virtual ICollection<TripDetail> TripDetails { get; set; } = new List<TripDetail>();

    [ForeignKey("TypeLookupId")]
    [InverseProperty("Bins")]
    public virtual Lookup? TypeLookup { get; set; }
}
