using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[Table("ContractAudiTrail")]
[Index("AuditTrailApplicationUserId", Name = "IX_ContractAudiTrail_AuditTrailApplicationUserId")]
[Index("ContractId", Name = "IX_ContractAudiTrail_ContractId")]
[Index("CreatedDate", Name = "IX_ContractAudiTrail_CreatedDate")]
[Index("IsDeleted", Name = "IX_ContractAudiTrail_IsDeleted")]
[Index("TenantId", Name = "IX_ContractAudiTrail_TenantId")]
public partial class ContractAudiTrail
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(200)]
    public string? Note { get; set; }

    [Column("OldStatusID")]
    public int OldStatusId { get; set; }

    [Column("NewStatusID")]
    public int NewStatusId { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public bool IsDeleted { get; set; }

    public Guid TenantId { get; set; }

    public Guid ContractId { get; set; }

    public Guid? AuditTrailApplicationUserId { get; set; }

    [ForeignKey("AuditTrailApplicationUserId")]
    [InverseProperty("ContractAudiTrails")]
    public virtual ApplicationUser? AuditTrailApplicationUser { get; set; }
}
