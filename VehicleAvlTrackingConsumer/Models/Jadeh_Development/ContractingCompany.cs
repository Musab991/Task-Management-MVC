using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[Index("CreatedDate", Name = "IX_ContractingCompanies_CreatedDate")]
[Index("IsDeleted", Name = "IX_ContractingCompanies_IsDeleted")]
[Index("TenantId", Name = "IX_ContractingCompanies_TenantId")]
public partial class ContractingCompany
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(200)]
    public string? Number { get; set; }

    [StringLength(200)]
    public string? NationalNumber { get; set; }

    [StringLength(200)]
    public string? PhoneNumber { get; set; }

    public int Type { get; set; }

    [Column("MainCRNumber")]
    [StringLength(200)]
    public string? MainCrnumber { get; set; }

    public bool CapitalSpecified { get; set; }

    [StringLength(200)]
    public string? CommercialLicenseNumber { get; set; }

    [StringLength(200)]
    public string? Address { get; set; }

    [Column("CRCapital")]
    public int Crcapital { get; set; }

    [Column("CityAR")]
    [StringLength(200)]
    public string? CityAr { get; set; }

    [StringLength(200)]
    public string? CityCode { get; set; }

    [Column("CityEN")]
    [StringLength(200)]
    public string? CityEn { get; set; }

    [StringLength(200)]
    public string? ContactNo { get; set; }

    [StringLength(200)]
    public string? Email { get; set; }

    [StringLength(200)]
    public string? ExpiryDate { get; set; }

    [StringLength(200)]
    public string? FaxNo { get; set; }

    [StringLength(200)]
    public string? IssueDate { get; set; }

    [Column("LegalTypeAR")]
    [StringLength(200)]
    public string? LegalTypeAr { get; set; }

    [Column("LegalTypeEN")]
    [StringLength(200)]
    public string? LegalTypeEn { get; set; }

    [StringLength(200)]
    public string? Nationality { get; set; }

    [StringLength(200)]
    public string? PhoneNo { get; set; }

    [StringLength(200)]
    public string? Status { get; set; }

    [StringLength(200)]
    public string? StatusId { get; set; }

    [StringLength(200)]
    public string? StatusReasonAr { get; set; }

    [Column("StatusReasonEN")]
    [StringLength(200)]
    public string? StatusReasonEn { get; set; }

    [Column("LegalTypeID")]
    [StringLength(200)]
    public string? LegalTypeId { get; set; }

    [Column("POBOX1")]
    [StringLength(200)]
    public string? Pobox1 { get; set; }

    [Column("POBOX2")]
    [StringLength(200)]
    public string? Pobox2 { get; set; }

    [StringLength(200)]
    public string? RecepDate { get; set; }

    [StringLength(200)]
    public string? TransDate { get; set; }

    [StringLength(200)]
    public string? Website { get; set; }

    [StringLength(200)]
    public string? ZipCode { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    [InverseProperty("ContractingCompany")]
    public virtual ICollection<ApplicationUser> ApplicationUsers { get; set; } = new List<ApplicationUser>();

    [InverseProperty("ContractingCompany")]
    public virtual ICollection<Bin> Bins { get; set; } = new List<Bin>();

    [InverseProperty("Entity")]
    public virtual ICollection<ContractingCompanyLocalization> ContractingCompanyLocalizations { get; set; } = new List<ContractingCompanyLocalization>();

    [InverseProperty("ContractingCompany")]
    public virtual ICollection<ContractingDevice> ContractingDevices { get; set; } = new List<ContractingDevice>();

    [InverseProperty("ContractingCompany")]
    public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();

    [InverseProperty("ContractingCompany")]
    public virtual ICollection<Crew> Crews { get; set; } = new List<Crew>();

    [InverseProperty("ContractingCompany")]
    public virtual ICollection<DisposalPoint> DisposalPoints { get; set; } = new List<DisposalPoint>();

    [InverseProperty("ContractingCompany")]
    public virtual ICollection<OperationalPlan> OperationalPlans { get; set; } = new List<OperationalPlan>();

    [InverseProperty("ContractingCompany")]
    public virtual ICollection<OvernightPoint> OvernightPoints { get; set; } = new List<OvernightPoint>();

    [InverseProperty("ContractingCompany")]
    public virtual ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
}
