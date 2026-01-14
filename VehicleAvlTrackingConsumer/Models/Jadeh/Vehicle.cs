using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh;

[Table("Vehicle")]
[Index("ContractTypeId", Name = "IX_Vehicle_ContractTypeId")]
[Index("ContractingCompanyId", Name = "IX_Vehicle_ContractingCompanyId")]
[Index("CreatedDate", Name = "IX_Vehicle_CreatedDate")]
[Index("IsDeleted", Name = "IX_Vehicle_IsDeleted")]
[Index("TenantId", Name = "IX_Vehicle_TenantId")]
[Index("TenantId", "IsDeleted", "VehicleTypeId", Name = "IX_Vehicle_Tenant_IsDeleted_VehicleTypeId")]
[Index("VehicleTypeId", Name = "IX_Vehicle_VehicleTypeId")]
public partial class Vehicle
{
    [Key]
    public Guid Id { get; set; }

    public Guid ContractingCompanyId { get; set; }

    [StringLength(50)]
    public string? PlateChar { get; set; }

    [StringLength(20)]
    public string? PlateNumber { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public Guid TenantId { get; set; }

    public bool Accreditation { get; set; }

    public Guid? ContractTypeId { get; set; }

    public int ManufactureYear { get; set; }

    [StringLength(200)]
    public string? ReferenceCode { get; set; }

    public long TagNumber { get; set; }

    public bool TagStatus { get; set; }

    public long TrackingDeviceNumber { get; set; }

    [Column("VIN")]
    [StringLength(200)]
    public string? Vin { get; set; }

    public Guid? VehicleTypeId { get; set; }

    public int VehicleWeight { get; set; }

    [ForeignKey("ContractTypeId")]
    [InverseProperty("Vehicles")]
    public virtual ContractType? ContractType { get; set; }

    [ForeignKey("ContractingCompanyId")]
    [InverseProperty("Vehicles")]
    public virtual ContractingCompany ContractingCompany { get; set; } = null!;

    [InverseProperty("Vehicle")]
    public virtual ICollection<OperationalPlan> OperationalPlans { get; set; } = new List<OperationalPlan>();


    [InverseProperty("Vehicle")]
    public virtual ICollection<Trip> TripVehicles { get; set; } = new List<Trip>();

    [InverseProperty("Vehicle")]
    public virtual VehicleLatestPoint? VehicleLatestPoint { get; set; }

    [InverseProperty("Vehicle")]
    public virtual ICollection<VehicleOperationalPlan> VehicleOperationalPlans { get; set; } = new List<VehicleOperationalPlan>();

    [InverseProperty("Vehicle")]
    public virtual ICollection<VehicleTrip> VehicleTrips { get; set; } = new List<VehicleTrip>();

    [ForeignKey("VehicleTypeId")]
    [InverseProperty("Vehicles")]
    public virtual VehicleType? VehicleType { get; set; }

    [InverseProperty("Vehicle")]
    public virtual ICollection<VehiclesAvlDatum> VehiclesAvlData { get; set; } = new List<VehiclesAvlDatum>();
}
