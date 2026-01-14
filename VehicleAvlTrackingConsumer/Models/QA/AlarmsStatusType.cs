using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class AlarmsStatusType
{
    public int Id { get; set; }

    public int DictionaryId { get; set; }

    public virtual ICollection<Alarm> Alarms { get; set; } = new List<Alarm>();

    public virtual Dictionary Dictionary { get; set; } = null!;
}
