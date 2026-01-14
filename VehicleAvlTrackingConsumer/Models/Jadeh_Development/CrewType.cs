using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[Table("CrewType")]
[Index("CreatedDate", Name = "IX_CrewType_CreatedDate")]
[Index("IsDeleted", Name = "IX_CrewType_IsDeleted")]
[Index("TenantId", Name = "IX_CrewType_TenantId")]
public partial class CrewType
{
    [Key]
    public Guid Id { get; set; }

    public int Type { get; set; }

    [StringLength(200)]
    public string? Name { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    [InverseProperty("Type")]
    public virtual ICollection<Crew> Crews { get; set; } = new List<Crew>();

    [InverseProperty("CrewType")]
    public virtual ICollection<ServiceCrewType> ServiceCrewTypes { get; set; } = new List<ServiceCrewType>();
}
