using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class Role
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public DateTime? InactiveSince { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    public int Type { get; set; }

    public virtual ICollection<ApplicationUser> ApplicationUsers { get; set; } = new List<ApplicationUser>();

    public virtual ICollection<RoleLocalization> RoleLocalizations { get; set; } = new List<RoleLocalization>();

    public virtual ICollection<RolePrivilege> RolePrivileges { get; set; } = new List<RolePrivilege>();
}
