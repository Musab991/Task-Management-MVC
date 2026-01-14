using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh;

[Table("TripFile")]
[Index("CreatedDate", Name = "IX_TripFile_CreatedDate")]
[Index("IsDeleted", Name = "IX_TripFile_IsDeleted")]
[Index("TenantId", Name = "IX_TripFile_TenantId")]
[Index("TripId", Name = "IX_TripFile_TripId")]
public partial class TripFile
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(200)]
    public string? FileName { get; set; }

    [StringLength(200)]
    public string? FilePath { get; set; }

    public Guid TripDetailsId { get; set; }

    public Guid? TripId { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public bool IsDeleted { get; set; }

    public Guid TenantId { get; set; }

    [ForeignKey("TripId")]
    [InverseProperty("TripFiles")]
    public virtual Trip? Trip { get; set; }
}
