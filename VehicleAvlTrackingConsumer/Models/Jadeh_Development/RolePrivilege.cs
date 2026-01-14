using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[PrimaryKey("RoleId", "PrivilegeId")]
[Index("CreatedDate", Name = "IX_RolePrivileges_CreatedDate")]
[Index("IsDeleted", Name = "IX_RolePrivileges_IsDeleted")]
[Index("PrivilegeId", Name = "IX_RolePrivileges_PrivilegeId")]
[Index("TenantId", Name = "IX_RolePrivileges_TenantId")]
public partial class RolePrivilege
{
    [Key]
    public int PrivilegeId { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    [Key]
    public int RoleId { get; set; }

    public int Id { get; set; }

    public bool IsDeleted { get; set; }

    [ForeignKey("PrivilegeId")]
    [InverseProperty("RolePrivileges")]
    public virtual Privilege Privilege { get; set; } = null!;

    [ForeignKey("RoleId")]
    [InverseProperty("RolePrivileges")]
    public virtual Role Role { get; set; } = null!;
}
