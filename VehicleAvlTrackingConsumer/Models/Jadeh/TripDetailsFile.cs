using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh;

[Table("TripDetailsFile")]
[Index("CreatedDate", Name = "IX_TripDetailsFile_CreatedDate")]
[Index("IsDeleted", Name = "IX_TripDetailsFile_IsDeleted")]
[Index("TenantId", Name = "IX_TripDetailsFile_TenantId")]
[Index("TripDetailsId", Name = "IX_TripDetailsFile_TripDetailsId")]
public partial class TripDetailsFile
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(200)]
    public string? FileName { get; set; }

    [StringLength(200)]
    public string? FilePath { get; set; }

    public Guid TripDetailsId { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public bool IsDeleted { get; set; }

    public Guid TenantId { get; set; }

    [ForeignKey("TripDetailsId")]
    [InverseProperty("TripDetailsFiles")]
    public virtual TripDetail TripDetails { get; set; } = null!;
}
