using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[Table("Nationality")]
[Index("CreatedDate", Name = "IX_Nationality_CreatedDate")]
[Index("IsDeleted", Name = "IX_Nationality_IsDeleted")]
[Index("TenantId", Name = "IX_Nationality_TenantId")]
public partial class Nationality
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(100)]
    public string Name { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public bool IsDeleted { get; set; }

    public Guid TenantId { get; set; }

    [InverseProperty("Nationality")]
    public virtual ICollection<Crew> Crews { get; set; } = new List<Crew>();
}
