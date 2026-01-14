using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[Index("CreatedDate", Name = "IX_PrivilegeGroups_CreatedDate")]
[Index("PrivilegeGroupId", Name = "IX_PrivilegeGroups_PrivilegeGroupId")]
[Index("TenantId", Name = "IX_PrivilegeGroups_TenantId")]
public partial class PrivilegeGroup
{
    [Key]
    public int Id { get; set; }

    [StringLength(200)]
    public string? Description { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    public int? PrivilegeGroupId { get; set; }

    public int DictionaryId { get; set; }

    [InverseProperty("PrivilegeGroupNavigation")]
    public virtual ICollection<PrivilegeGroup> InversePrivilegeGroupNavigation { get; set; } = new List<PrivilegeGroup>();

    [ForeignKey("PrivilegeGroupId")]
    [InverseProperty("InversePrivilegeGroupNavigation")]
    public virtual PrivilegeGroup? PrivilegeGroupNavigation { get; set; }

    [InverseProperty("PrivilegeGroup")]
    public virtual ICollection<Privilege> Privileges { get; set; } = new List<Privilege>();
}
