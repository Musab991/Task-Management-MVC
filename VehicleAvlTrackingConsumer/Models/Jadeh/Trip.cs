using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh;

[Index("CreatedDate", Name = "IX_Trips_CreatedDate")]
[Index("DisposalPointId", Name = "IX_Trips_DisposalPointId")]
[Index("DriverId", Name = "IX_Trips_DriverId")]
[Index("IsDeleted", Name = "IX_Trips_IsDeleted")]
[Index("IsDeleted", "TenantId", Name = "IX_Trips_IsDeleted_TenantId")]
[Index("OperationManagerId", Name = "IX_Trips_OperationManagerId")]
[Index("OperationalPlansId", Name = "IX_Trips_OperationalPlansId")]
[Index("OvernightPointId", Name = "IX_Trips_OvernightPointId")]
[Index("TenantId", Name = "IX_Trips_TenantId")]
[Index("TripDate", Name = "IX_Trips_TripDate")]
[Index("VehicleId", Name = "IX_Trips_VehicleId")]
public partial class Trip
{
    [Key]
    public Guid Id { get; set; }

    public Guid OperationalPlansId { get; set; }

    public DateTime StartTrip { get; set; }

    public DateTime EndTrip { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public bool IsDeleted { get; set; }

    public Guid TenantId { get; set; }

    public Guid? DisposalPointId { get; set; }

    public Guid? DriverId { get; set; }

    public Guid? OvernightPointId { get; set; }

    public Guid? VehicleId { get; set; }

    public DateTime TripDate { get; set; }

    [StringLength(200)]
    public string? ReferenceCode { get; set; }

    public int Status { get; set; }

    public Guid? SupervisorId { get; set; }

    public Guid? OperationManagerId { get; set; }


    [ForeignKey("DisposalPointId")]
    [InverseProperty("Trips")]
    public virtual DisposalPoint? DisposalPoint { get; set; }

    [ForeignKey("DriverId")]
    [InverseProperty("TripDrivers")]
    public virtual Crew? Driver { get; set; }

    [InverseProperty("Trip")]
    public virtual ICollection<DriverTrip> DriverTrips { get; set; } = new List<DriverTrip>();

    [ForeignKey("OperationManagerId")]
    [InverseProperty("TripOperationManagers")]
    public virtual Crew? OperationManager { get; set; }

    [ForeignKey("OperationalPlansId")]
    [InverseProperty("Trips")]
    public virtual OperationalPlan OperationalPlans { get; set; } = null!;

    [ForeignKey("OvernightPointId")]
    [InverseProperty("Trips")]
    public virtual OvernightPoint? OvernightPoint { get; set; }

    [InverseProperty("Trip")]
    public virtual ICollection<TripDetail> TripDetails { get; set; } = new List<TripDetail>();

    [InverseProperty("Trip")]
    public virtual ICollection<TripFile> TripFiles { get; set; } = new List<TripFile>();

    [InverseProperty("Entity")]
    public virtual ICollection<TripLocalizationLocalization> TripLocalizationLocalizations { get; set; } = new List<TripLocalizationLocalization>();

    [InverseProperty("Trip")]
    public virtual TripProcessingSummary? TripProcessingSummary { get; set; }

    [ForeignKey("VehicleId")]
    [InverseProperty("TripVehicles")]
    public virtual Vehicle? Vehicle { get; set; }

 
    [InverseProperty("Trip")]
    public virtual ICollection<VehicleLatestPoint> VehicleLatestPoints { get; set; } = new List<VehicleLatestPoint>();

    [InverseProperty("Trip")]
    public virtual ICollection<VehicleTrip> VehicleTrips { get; set; } = new List<VehicleTrip>();

    [InverseProperty("Trip")]
    public virtual ICollection<VehiclesAvlDatum> VehiclesAvlData { get; set; } = new List<VehiclesAvlDatum>();
}
