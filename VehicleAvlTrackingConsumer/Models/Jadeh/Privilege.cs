using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh;

[Index("CreatedDate", Name = "IX_Privileges_CreatedDate")]
[Index("IsDeleted", Name = "IX_Privileges_IsDeleted")]
[Index("PrivilegeGroupId", Name = "IX_Privileges_PrivilegeGroupId")]
[Index("TenantId", Name = "IX_Privileges_TenantId")]
public partial class Privilege
{
    [StringLength(200)]
    public string? Description { get; set; }

    public int? PrivilegeGroupId { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    public bool IsDeleted { get; set; }

    public int Type { get; set; }

    public int? DictionaryId { get; set; }

    [Key]
    public int Id { get; set; }

    [ForeignKey("DictionaryId")]
    [InverseProperty("Privileges")]
    public virtual Dictionary? Dictionary { get; set; }

    [ForeignKey("PrivilegeGroupId")]
    [InverseProperty("Privileges")]
    public virtual PrivilegeGroup? PrivilegeGroup { get; set; }

    [InverseProperty("Privilege")]
    public virtual ICollection<RolePrivilege> RolePrivileges { get; set; } = new List<RolePrivilege>();
}
