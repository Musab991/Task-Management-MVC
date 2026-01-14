using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[PrimaryKey("JobId", "Id")]
[Table("State", Schema = "HangfireDev")]
[Index("CreatedAt", Name = "IX_HangFire_State_CreatedAt")]
public partial class State1
{
    [Key]
    public long Id { get; set; }

    [Key]
    public long JobId { get; set; }

    [StringLength(20)]
    public string Name { get; set; } = null!;

    [StringLength(100)]
    public string? Reason { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreatedAt { get; set; }

    public string? Data { get; set; }

    [ForeignKey("JobId")]
    [InverseProperty("State1s")]
    public virtual Job1 Job { get; set; } = null!;
}
