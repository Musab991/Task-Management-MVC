using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[Index("BinId", Name = "IX_TripDetails_BinId")]
[Index("ContractServiceMapGeometryId", Name = "IX_TripDetails_ContractServiceMapGeometryId")]
[Index("CreatedDate", Name = "IX_TripDetails_CreatedDate")]
[Index("IsDeleted", Name = "IX_TripDetails_IsDeleted")]
[Index("TenantId", Name = "IX_TripDetails_TenantId")]
[Index("TripId", Name = "IX_TripDetails_TripId")]
public partial class TripDetail
{
    [Key]
    public Guid Id { get; set; }

    public Guid TripId { get; set; }

    public int? CompletionType { get; set; }

    [StringLength(200)]
    public string? TagId { get; set; }

    public double ActualWeight { get; set; }

    public int Order { get; set; }

    public Guid? BinId { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public bool IsDeleted { get; set; }

    public Guid TenantId { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal StreetWeightPercentage { get; set; }

    public double StreetLength { get; set; }

    [MaxLength(32)]
    public byte[]? TagHash { get; set; }

    [StringLength(200)]
    public string? ReferenceCode { get; set; }

    public Guid? ContractServiceMapGeometryId { get; set; }

    [ForeignKey("BinId")]
    [InverseProperty("TripDetails")]
    public virtual Bin? Bin { get; set; }

    [ForeignKey("ContractServiceMapGeometryId")]
    [InverseProperty("TripDetails")]
    public virtual ContractServiceMapGeometry? ContractServiceMapGeometry { get; set; }

    [ForeignKey("TripId")]
    [InverseProperty("TripDetails")]
    public virtual Trip Trip { get; set; } = null!;

    [InverseProperty("TripDetails")]
    public virtual ICollection<TripDetailsFile> TripDetailsFiles { get; set; } = new List<TripDetailsFile>();

    [InverseProperty("TripDetails")]
    public virtual TripDetailsProcessingSummary? TripDetailsProcessingSummary { get; set; }
}
