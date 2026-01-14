using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh;

[Table("ContractMapGeometry")]
[Index("ContractId", Name = "IX_ContractMapGeometry_ContractId")]
[Index("IsDeleted", Name = "IX_ContractMapGeometry_IsDeleted")]
[Index("TenantId", Name = "IX_ContractMapGeometry_TenantId")]
public partial class ContractMapGeometry
{
    [Key]
    public Guid Id { get; set; }

    public string? GeometryJson { get; set; }

    public string PropertiesJson { get; set; } = null!;

    public Guid ContractId { get; set; }

    public Guid TenantId { get; set; }

    public bool IsDeleted { get; set; }

    [ForeignKey("ContractId")]
    [InverseProperty("ContractMapGeometries")]
    public virtual Contract Contract { get; set; } = null!;
}
