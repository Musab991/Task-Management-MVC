using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class ApplicationUser
{
    public Guid Id { get; set; }

    public byte[]? Image { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public string Name { get; set; } = null!;

    public string SurName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public int? RoleId { get; set; }

    public Guid? ContractingCompanyId { get; set; }

    public bool? HasContract { get; set; }

    public DateTime? RoleAssignedDate { get; set; }

    public DateTime? LastAccessDateTime { get; set; }

    public string? RefreshToken { get; set; }

    public DateTime? RefreshTokenExpiry { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    public string? NationalId { get; set; }

    public Guid? CrewId { get; set; }

    public bool IsHuawei { get; set; }

    public string? MobileToken { get; set; }

    public string? Locale { get; set; }

    public DateTime? BirthDay { get; set; }

    public virtual ICollection<ApplicationUserContractType> ApplicationUserContractTypes { get; set; } = new List<ApplicationUserContractType>();

    public virtual ICollection<ApplicationUserLocalization> ApplicationUserLocalizations { get; set; } = new List<ApplicationUserLocalization>();

    public virtual ICollection<ContractAudiTrail> ContractAudiTrails { get; set; } = new List<ContractAudiTrail>();

    public virtual ICollection<ContractTypeManager> ContractTypeManagers { get; set; } = new List<ContractTypeManager>();

    public virtual ICollection<ContractTypeTransporter> ContractTypeTransporters { get; set; } = new List<ContractTypeTransporter>();

    public virtual ContractingCompany? ContractingCompany { get; set; }

    public virtual Crew? Crew { get; set; }

    public virtual Role? Role { get; set; }
}
