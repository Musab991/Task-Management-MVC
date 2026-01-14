using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class Privilege
{
    public string? Description { get; set; }

    public int? PrivilegeGroupId { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    public bool IsDeleted { get; set; }

    public int Type { get; set; }

    public int? DictionaryId { get; set; }

    public int Id { get; set; }

    public virtual Dictionary? Dictionary { get; set; }

    public virtual PrivilegeGroup? PrivilegeGroup { get; set; }

    public virtual ICollection<RolePrivilege> RolePrivileges { get; set; } = new List<RolePrivilege>();
}
