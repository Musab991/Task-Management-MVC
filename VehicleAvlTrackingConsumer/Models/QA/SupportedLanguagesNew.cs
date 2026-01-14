using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class SupportedLanguagesNew
{
    public int Id { get; set; }

    public string Language { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Direction { get; set; } = null!;

    public bool Active { get; set; }
}
