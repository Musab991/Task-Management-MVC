using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class Vehicle
{
    public Guid Id { get; set; }

    public Guid ContractingCompanyId { get; set; }

    public string? PlateChar { get; set; }

    public string? PlateNumber { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    public bool Accreditation { get; set; }

    public Guid? ContractTypeId { get; set; }

    public int ManufactureYear { get; set; }

    public string? ReferenceCode { get; set; }

    public long TagNumber { get; set; }

    public bool TagStatus { get; set; }

    public long TrackingDeviceNumber { get; set; }

    public string? Vin { get; set; }

    public Guid? VehicleTypeId { get; set; }

    public int VehicleWeight { get; set; }

    public virtual ContractType? ContractType { get; set; }

    public virtual ContractingCompany ContractingCompany { get; set; } = null!;

    public virtual ICollection<OperationalPlan> OperationalPlans { get; set; } = new List<OperationalPlan>();

    public virtual ICollection<Trip> TripVehicleId1Navigations { get; set; } = new List<Trip>();

    public virtual ICollection<Trip> TripVehicles { get; set; } = new List<Trip>();

    public virtual VehicleLatestPoint? VehicleLatestPoint { get; set; }

    public virtual ICollection<VehicleOperationalPlan> VehicleOperationalPlans { get; set; } = new List<VehicleOperationalPlan>();

    public virtual ICollection<VehicleTrip> VehicleTrips { get; set; } = new List<VehicleTrip>();

    public virtual VehicleType? VehicleType { get; set; }

    public virtual ICollection<VehiclesAvlDatum> VehiclesAvlData { get; set; } = new List<VehiclesAvlDatum>();
}
