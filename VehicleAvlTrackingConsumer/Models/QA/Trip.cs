using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class Trip
{
    public Guid Id { get; set; }

    public Guid OperationalPlansId { get; set; }

    public DateTime StartTrip { get; set; }

    public DateTime EndTrip { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public bool IsDeleted { get; set; }

    public Guid TenantId { get; set; }

    public Guid? DisposalPointId { get; set; }

    public Guid? DriverId { get; set; }

    public Guid? OvernightPointId { get; set; }

    public Guid? VehicleId { get; set; }

    public DateTime TripDate { get; set; }

    public string? ReferenceCode { get; set; }

    public int Status { get; set; }

    public Guid? SupervisorId { get; set; }

    public Guid? OperationManagerId { get; set; }

    public Guid? VehicleId1 { get; set; }

    public virtual DisposalPoint? DisposalPoint { get; set; }

    public virtual Crew? Driver { get; set; }

    public virtual ICollection<DriverTrip> DriverTrips { get; set; } = new List<DriverTrip>();

    public virtual Crew? OperationManager { get; set; }

    public virtual OperationalPlan OperationalPlans { get; set; } = null!;

    public virtual OvernightPoint? OvernightPoint { get; set; }

    public virtual ICollection<TripDetail> TripDetails { get; set; } = new List<TripDetail>();

    public virtual ICollection<TripFile> TripFiles { get; set; } = new List<TripFile>();

    public virtual ICollection<TripLocalizationLocalization> TripLocalizationLocalizations { get; set; } = new List<TripLocalizationLocalization>();

    public virtual TripProcessingSummary? TripProcessingSummary { get; set; }

    public virtual Vehicle? Vehicle { get; set; }

    public virtual Vehicle? VehicleId1Navigation { get; set; }

    public virtual ICollection<VehicleLatestPoint> VehicleLatestPoints { get; set; } = new List<VehicleLatestPoint>();

    public virtual ICollection<VehicleTrip> VehicleTrips { get; set; } = new List<VehicleTrip>();

    public virtual ICollection<VehiclesAvlDatum> VehiclesAvlData { get; set; } = new List<VehiclesAvlDatum>();
}
