using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh;

[Table("VehicleAvlDataPatch")]
[Index("IsDeleted", Name = "IX_VehicleAvlDataPatch_IsDeleted")]
[Index("TenantId", Name = "IX_VehicleAvlDataPatch_TenantId")]
public partial class VehicleAvlDataPatch
{
    [Key]
    public Guid Id { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public DateTime MovementTime { get; set; }

    public Guid TenantId { get; set; }

    [StringLength(200)]
    public string? Tag { get; set; }

    [StringLength(200)]
    public string? PlateNumber { get; set; }

    [Column("IMEI")]
    [StringLength(200)]
    public string? Imei { get; set; }

    public DateTime WasteCollectionTime { get; set; }

    public double? WasteLatitude { get; set; }

    public double? WasteLongitude { get; set; }

    [StringLength(200)]
    public string? LastTag { get; set; }

    public double? GrossWeight { get; set; }

    public bool IsDeleted { get; set; }

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

    public double? Ed0 { get; set; }

    public double? Ed1 { get; set; }

    public double? Input1 { get; set; }

    public double? Input2 { get; set; }

    public double? Input3 { get; set; }

    public double? Input4 { get; set; }

    public double? Input5 { get; set; }

    [StringLength(200)]
    public string? Createdby { get; set; }

    public Guid ModifiedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime ModifiedDate { get; set; }

    public Guid? TripId { get; set; }

    public Guid VehicleId { get; set; }
}
