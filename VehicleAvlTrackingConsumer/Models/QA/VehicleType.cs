using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class VehicleType
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    public string? Icon { get; set; }

    public int Type { get; set; }

    public virtual ICollection<ServiceVehicleType> ServiceVehicleTypes { get; set; } = new List<ServiceVehicleType>();

    public virtual ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();

    public virtual ICollection<ZonesVehicle> ZonesVehicles { get; set; } = new List<ZonesVehicle>();
}
