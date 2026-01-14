using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[Index("CreatedDate", Name = "IX_VehiclesAvlData_CreatedDate")]
[Index("IsDeleted", Name = "IX_VehiclesAvlData_IsDeleted")]
[Index("TenantId", Name = "IX_VehiclesAvlData_TenantId")]
[Index("TripId", Name = "IX_VehiclesAvlData_TripId")]
[Index("VehicleId", Name = "IX_VehiclesAvlData_VehicleId")]
public partial class VehiclesAvlDatum
{
    [Key]
    public Guid Id { get; set; }

    public Guid VehicleId { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public DateTime MovementTime { get; set; }

    public bool? Priority { get; set; }

    public double? Altitude { get; set; }

    public double? Angle { get; set; }

    public double? Speed { get; set; }

    public bool? Movement { get; set; }

    [StringLength(200)]
    public string? DigitalInput1 { get; set; }

    [StringLength(200)]
    public string? AnalogInput1 { get; set; }

    public bool? Ignition { get; set; }

    public double? Distance { get; set; }

    public double? TotalDistance { get; set; }

    public int? GreenDrivingType { get; set; }

    public int? EventId { get; set; }

    public string? Tag { get; set; }

    [StringLength(200)]
    public string? PlateNumber { get; set; }

    [Column("IMEI", TypeName = "nvarchar(max)")]
    public string Imei { get; set; } = null!;

    public DateTime WasteCollectionTime { get; set; }

    public double? WasteLatitude { get; set; }

    public double? WasteLongitude { get; set; }

    public string? LastTag { get; set; }

    public double? GrossWeight { get; set; }

    public double? Ed0 { get; set; }

    public double? Ed1 { get; set; }

    public double? Input1 { get; set; }

    public double? Input2 { get; set; }

    public double? Input3 { get; set; }

    public double? Input4 { get; set; }

    public double? Input5 { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    public Guid? TripId { get; set; }

    public bool IsProcessed { get; set; }

    public DateTime? ProcessedDate { get; set; }

    [ForeignKey("TripId")]
    [InverseProperty("VehiclesAvlData")]
    public virtual Trip? Trip { get; set; }

    [ForeignKey("VehicleId")]
    [InverseProperty("VehiclesAvlData")]
    public virtual Vehicle Vehicle { get; set; } = null!;



}


