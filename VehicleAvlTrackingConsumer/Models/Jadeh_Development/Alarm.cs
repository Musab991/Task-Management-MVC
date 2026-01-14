using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[Index("AlarmsStatusTypeId", Name = "IX_Alarms_AlarmsStatusTypeId")]
[Index("CreatedDate", Name = "IX_Alarms_CreatedDate")]
[Index("IsDeleted", Name = "IX_Alarms_IsDeleted")]
[Index("TenantId", Name = "IX_Alarms_TenantId")]
public partial class Alarm
{
    [Key]
    public Guid Id { get; set; }

    public Guid ContractingCompanyId { get; set; }

    public Guid TripId { get; set; }

    public Guid DriverId { get; set; }

    public Guid VehicleId { get; set; }

    public int AlarmsStatusTypeId { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public bool IsDeleted { get; set; }

    public Guid TenantId { get; set; }

    public int NotificationTypeId { get; set; }

    [ForeignKey("AlarmsStatusTypeId")]
    [InverseProperty("Alarms")]
    public virtual AlarmsStatusType AlarmsStatusType { get; set; } = null!;
}
