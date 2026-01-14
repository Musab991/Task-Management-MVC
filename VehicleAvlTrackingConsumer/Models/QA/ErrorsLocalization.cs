using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class ErrorsLocalization
{
    public int Id { get; set; }

    public string Locale { get; set; } = null!;

    public string Key { get; set; } = null!;

    public string Text { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool IsDefault { get; set; }
}
