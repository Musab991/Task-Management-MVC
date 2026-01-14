using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class Crew
{
    public Guid Id { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    public string? Address { get; set; }

    public string? CardNationalId { get; set; }

    public Guid? TypeId { get; set; }

    public DateTime? Dob { get; set; }

    public DateTime? LicenseExpiryDate { get; set; }

    public string? LicenseNumber { get; set; }

    public Guid? LicenseTypeId { get; set; }

    public Guid? NationalityId { get; set; }

    public int NoOfExperinceYears { get; set; }

    public Guid? ContractTypeId { get; set; }

    public Guid? ContractingCompanyId { get; set; }

    public DateTime BirthDay { get; set; }

    public virtual ApplicationUser? ApplicationUser { get; set; }

    public virtual ContractType? ContractType { get; set; }

    public virtual ContractingCompany? ContractingCompany { get; set; }

    public virtual ICollection<CrewLocalization> CrewLocalizations { get; set; } = new List<CrewLocalization>();

    public virtual ICollection<CrewOperationalPlan> CrewOperationalPlans { get; set; } = new List<CrewOperationalPlan>();

    public virtual ICollection<DriverOperationalPlan> DriverOperationalPlans { get; set; } = new List<DriverOperationalPlan>();

    public virtual ICollection<DriverTrip> DriverTrips { get; set; } = new List<DriverTrip>();

    public virtual LicenseType? LicenseType { get; set; }

    public virtual Nationality? Nationality { get; set; }

    public virtual ICollection<OperationalPlan> OperationalPlanDrivers { get; set; } = new List<OperationalPlan>();

    public virtual ICollection<OperationalPlan> OperationalPlanSupervisors { get; set; } = new List<OperationalPlan>();

    public virtual ICollection<Trip> TripDrivers { get; set; } = new List<Trip>();

    public virtual ICollection<Trip> TripOperationManagers { get; set; } = new List<Trip>();

    public virtual CrewType? Type { get; set; }
}
