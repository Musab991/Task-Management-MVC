using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh;

[PrimaryKey("ServiceId", "CrewTypeId")]
[Table("ServiceCrewType")]
[Index("CreatedDate", Name = "IX_ServiceCrewType_CreatedDate")]
[Index("CrewTypeId", Name = "IX_ServiceCrewType_CrewTypeId")]
[Index("IsDeleted", Name = "IX_ServiceCrewType_IsDeleted")]
[Index("TenantId", Name = "IX_ServiceCrewType_TenantId")]
public partial class ServiceCrewType
{
    [Key]
    public Guid ServiceId { get; set; }

    [Key]
    public Guid CrewTypeId { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    [ForeignKey("CrewTypeId")]
    [InverseProperty("ServiceCrewTypes")]
    public virtual CrewType CrewType { get; set; } = null!;

    [ForeignKey("ServiceId")]
    [InverseProperty("ServiceCrewTypes")]
    public virtual Service Service { get; set; } = null!;
}
