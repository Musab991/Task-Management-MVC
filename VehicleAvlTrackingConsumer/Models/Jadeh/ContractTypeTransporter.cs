using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh;

[Table("ContractTypeTransporter")]
[Index("ContractTypeId", Name = "IX_ContractTypeTransporter_ContractTypeId")]
[Index("CreatedDate", Name = "IX_ContractTypeTransporter_CreatedDate")]
[Index("IsDeleted", Name = "IX_ContractTypeTransporter_IsDeleted")]
[Index("TenantId", Name = "IX_ContractTypeTransporter_TenantId")]
[Index("TransporterId", Name = "IX_ContractTypeTransporter_TransporterId")]
public partial class ContractTypeTransporter
{
    public Guid ContractTypeId { get; set; }

    public Guid TransporterId { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public bool IsDeleted { get; set; }

    public Guid TenantId { get; set; }

    [Key]
    public Guid Id { get; set; }

    [ForeignKey("ContractTypeId")]
    [InverseProperty("ContractTypeTransporters")]
    public virtual ContractType ContractType { get; set; } = null!;

    [ForeignKey("TransporterId")]
    [InverseProperty("ContractTypeTransporters")]
    public virtual ApplicationUser Transporter { get; set; } = null!;
}
