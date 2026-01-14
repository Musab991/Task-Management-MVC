using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[Table("ContractServiceMapGeometry")]
[Index("BinId", Name = "IX_ContractServiceMapGeometry_BinId")]
[Index("ContractId", Name = "IX_ContractServiceMapGeometry_ContractId")]
[Index("ContractServiceId", Name = "IX_ContractServiceMapGeometry_ContractServiceId")]
[Index("CreatedDate", Name = "IX_ContractServiceMapGeometry_CreatedDate")]
[Index("IsDeleted", Name = "IX_ContractServiceMapGeometry_IsDeleted")]
[Index("TenantId", Name = "IX_ContractServiceMapGeometry_TenantId")]
public partial class ContractServiceMapGeometry
{
    [Key]
    public Guid Id { get; set; }

    public string? GeometryJson { get; set; }

    public string? PropertiesJson { get; set; }

    public Guid ContractId { get; set; }

    public Guid TenantId { get; set; }

    public Guid? BinId { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    [StringLength(200)]
    public string? Tag { get; set; }

    public bool IsDeleted { get; set; }

    public Guid? ContractServiceId { get; set; }

    public int GeoType { get; set; }

    public double? Length { get; set; }

    public double? Area { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    [StringLength(200)]
    public string? ReferenceCode { get; set; }

    [ForeignKey("BinId")]
    [InverseProperty("ContractServiceMapGeometries")]
    public virtual Bin? Bin { get; set; }

    [ForeignKey("ContractId")]
    [InverseProperty("ContractServiceMapGeometries")]
    public virtual Contract Contract { get; set; } = null!;

    [ForeignKey("ContractServiceId")]
    [InverseProperty("ContractServiceMapGeometries")]
    public virtual ContractService? ContractService { get; set; }

    [InverseProperty("ContractServiceMapGeometry")]
    public virtual ICollection<OperationalPlanDetail> OperationalPlanDetails { get; set; } = new List<OperationalPlanDetail>();

    [InverseProperty("ContractServiceMapGeometry")]
    public virtual ICollection<TripDetail> TripDetails { get; set; } = new List<TripDetail>();
}
