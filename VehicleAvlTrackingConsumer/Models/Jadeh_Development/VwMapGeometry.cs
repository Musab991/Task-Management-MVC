using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

[Keyless]
public partial class VwMapGeometry
{
    public Guid Id { get; set; }

    public string? GeometryJson { get; set; }

    public string? PropertiesJson { get; set; }

    public Guid ContractId { get; set; }

    public Guid TenantId { get; set; }

    public Guid? BinId { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    [StringLength(200)]
    public string? Tag { get; set; }

    public bool IsDeleted { get; set; }

    public Guid? ContractServiceId { get; set; }

    public int GeoType { get; set; }

    public double? Length { get; set; }

    public double? Area { get; set; }
}
