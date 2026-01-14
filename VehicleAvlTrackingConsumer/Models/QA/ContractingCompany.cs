using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class ContractingCompany
{
    public Guid Id { get; set; }

    public string? Number { get; set; }

    public string? NationalNumber { get; set; }

    public string? PhoneNumber { get; set; }

    public int Type { get; set; }

    public string? MainCrnumber { get; set; }

    public bool CapitalSpecified { get; set; }

    public string? CommercialLicenseNumber { get; set; }

    public string? Address { get; set; }

    public int Crcapital { get; set; }

    public string? CityAr { get; set; }

    public string? CityCode { get; set; }

    public string? CityEn { get; set; }

    public string? ContactNo { get; set; }

    public string? Email { get; set; }

    public string? ExpiryDate { get; set; }

    public string? FaxNo { get; set; }

    public string? IssueDate { get; set; }

    public string? LegalTypeAr { get; set; }

    public string? LegalTypeEn { get; set; }

    public string? Nationality { get; set; }

    public string? PhoneNo { get; set; }

    public string? Status { get; set; }

    public string? StatusId { get; set; }

    public string? StatusReasonAr { get; set; }

    public string? StatusReasonEn { get; set; }

    public string? LegalTypeId { get; set; }

    public string? Pobox1 { get; set; }

    public string? Pobox2 { get; set; }

    public string? RecepDate { get; set; }

    public string? TransDate { get; set; }

    public string? Website { get; set; }

    public string? ZipCode { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    public virtual ICollection<ApplicationUser> ApplicationUsers { get; set; } = new List<ApplicationUser>();

    public virtual ICollection<Bin> Bins { get; set; } = new List<Bin>();

    public virtual ICollection<ContractingCompanyLocalization> ContractingCompanyLocalizations { get; set; } = new List<ContractingCompanyLocalization>();

    public virtual ICollection<ContractingDevice> ContractingDevices { get; set; } = new List<ContractingDevice>();

    public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();

    public virtual ICollection<Crew> Crews { get; set; } = new List<Crew>();

    public virtual ICollection<DisposalPoint> DisposalPoints { get; set; } = new List<DisposalPoint>();

    public virtual ICollection<OperationalPlan> OperationalPlans { get; set; } = new List<OperationalPlan>();

    public virtual ICollection<OvernightPoint> OvernightPoints { get; set; } = new List<OvernightPoint>();

    public virtual ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
}
