using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[Index("CreatedDate", Name = "IX_Roles_CreatedDate")]
[Index("IsDeleted", Name = "IX_Roles_IsDeleted")]
[Index("TenantId", Name = "IX_Roles_TenantId")]
public partial class Role
{
    [Key]
    public int Id { get; set; }

    [StringLength(200)]
    public string? Description { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public DateTime? InactiveSince { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    public int Type { get; set; }

    [InverseProperty("Role")]
    public virtual ICollection<ApplicationUser> ApplicationUsers { get; set; } = new List<ApplicationUser>();

    [InverseProperty("Entity")]
    public virtual ICollection<RoleLocalization> RoleLocalizations { get; set; } = new List<RoleLocalization>();

    [InverseProperty("Role")]
    public virtual ICollection<RolePrivilege> RolePrivileges { get; set; } = new List<RolePrivilege>();
}
