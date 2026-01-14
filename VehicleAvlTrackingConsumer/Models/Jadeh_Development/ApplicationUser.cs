using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[Index("ContractTypeId", Name = "IX_ApplicationUsers_ContractTypeId")]
[Index("ContractingCompanyId", Name = "IX_ApplicationUsers_ContractingCompanyId")]
[Index("CreatedDate", Name = "IX_ApplicationUsers_CreatedDate")]
[Index("IsDeleted", Name = "IX_ApplicationUsers_IsDeleted")]
[Index("PhoneNumber", Name = "IX_ApplicationUsers_PhoneNumber")]
[Index("RoleId", Name = "IX_ApplicationUsers_RoleId")]
[Index("TenantId", Name = "IX_ApplicationUsers_TenantId")]
public partial class ApplicationUser
{
    [Key]
    public Guid Id { get; set; }

    public byte[]? Image { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    [StringLength(100)]
    public string Name { get; set; } = null!;

    [StringLength(100)]
    public string SurName { get; set; } = null!;

    [StringLength(255)]
    public string Email { get; set; } = null!;

    [StringLength(255)]
    public string Password { get; set; } = null!;

    [StringLength(50)]
    public string? PhoneNumber { get; set; }

    public int? RoleId { get; set; }

    public Guid? ContractingCompanyId { get; set; }

    public bool? HasContract { get; set; }

    public DateTime? RoleAssignedDate { get; set; }

    public DateTime? LastAccessDateTime { get; set; }

    [StringLength(200)]
    public string? RefreshToken { get; set; }

    public DateTime? RefreshTokenExpiry { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    [StringLength(200)]
    public string? NationalId { get; set; }

    public Guid? CrewId { get; set; }

    public bool IsHuawei { get; set; }

    public string? MobileToken { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? Locale { get; set; }

    public DateTime? BirthDay { get; set; }

    public Guid? ContractTypeId { get; set; }

    public Guid? TypeId { get; set; }

    [InverseProperty("ApplicationUser")]
    public virtual ICollection<ApplicationUserContractType> ApplicationUserContractTypes { get; set; } = new List<ApplicationUserContractType>();

    [InverseProperty("Entity")]
    public virtual ICollection<ApplicationUserLocalization> ApplicationUserLocalizations { get; set; } = new List<ApplicationUserLocalization>();

    [InverseProperty("AuditTrailApplicationUser")]
    public virtual ICollection<ContractAudiTrail> ContractAudiTrails { get; set; } = new List<ContractAudiTrail>();

    [ForeignKey("ContractTypeId")]
    [InverseProperty("ApplicationUsers")]
    public virtual ContractType? ContractType { get; set; }

    [InverseProperty("Manager")]
    public virtual ICollection<ContractTypeManager> ContractTypeManagers { get; set; } = new List<ContractTypeManager>();

    [InverseProperty("Transporter")]
    public virtual ICollection<ContractTypeTransporter> ContractTypeTransporters { get; set; } = new List<ContractTypeTransporter>();

    [ForeignKey("ContractingCompanyId")]
    [InverseProperty("ApplicationUsers")]
    public virtual ContractingCompany? ContractingCompany { get; set; }

    [ForeignKey("CrewId")]
    [InverseProperty("ApplicationUser")]
    public virtual Crew? Crew { get; set; }

    [ForeignKey("RoleId")]
    [InverseProperty("ApplicationUsers")]
    public virtual Role? Role { get; set; }
}
