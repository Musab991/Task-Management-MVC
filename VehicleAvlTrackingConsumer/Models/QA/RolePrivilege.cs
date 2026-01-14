using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class RolePrivilege
{
    public int PrivilegeId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    public int RoleId { get; set; }

    public int Id { get; set; }

    public bool IsDeleted { get; set; }

    public virtual Privilege Privilege { get; set; } = null!;

    public virtual Role Role { get; set; } = null!;
}
