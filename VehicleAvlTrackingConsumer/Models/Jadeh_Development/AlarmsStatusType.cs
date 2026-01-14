using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[Index("DictionaryId", Name = "IX_AlarmsStatusTypes_DictionaryId")]
public partial class AlarmsStatusType
{
    [Key]
    public int Id { get; set; }

    public int DictionaryId { get; set; }

    [InverseProperty("AlarmsStatusType")]
    public virtual ICollection<Alarm> Alarms { get; set; } = new List<Alarm>();

    [ForeignKey("DictionaryId")]
    [InverseProperty("AlarmsStatusTypes")]
    public virtual Dictionary Dictionary { get; set; } = null!;
}
