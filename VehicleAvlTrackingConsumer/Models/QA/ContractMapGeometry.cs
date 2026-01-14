using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class ContractMapGeometry
{
    public Guid Id { get; set; }

    public string? GeometryJson { get; set; }

    public string PropertiesJson { get; set; } = null!;

    public Guid ContractId { get; set; }

    public Guid TenantId { get; set; }

    public bool IsDeleted { get; set; }

    public virtual Contract Contract { get; set; } = null!;
}
