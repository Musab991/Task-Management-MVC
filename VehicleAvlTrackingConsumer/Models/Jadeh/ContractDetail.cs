using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VehicleAvlTrackingConsumer.Models.Jadeh;

[Index("ContractServiceId", Name = "IX_ContractDetails_ContractServiceId", IsUnique = true)]
[Index("CreatedDate", Name = "IX_ContractDetails_CreatedDate")]
[Index("IsDeleted", Name = "IX_ContractDetails_IsDeleted")]
[Index("TenantId", Name = "IX_ContractDetails_TenantId")]
public partial class ContractDetail
{
    [Key]
    public Guid Id { get; set; }

    public int? ServiceFrequency { get; set; }

    public double AcceptanceRateOfOperationalPlans { get; set; }

    public int NumberOfVehicles { get; set; }

    public int NumberOfContainers { get; set; }

    public int NumberOfWorkers { get; set; }

    public Guid ContractServiceId { get; set; }

    public DateTime CreatedDate { get; set; }

    [StringLength(255)]
    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    [StringLength(255)]
    public string? ModifiedBy { get; set; }

    public bool IsDeleted { get; set; }

    public Guid TenantId { get; set; }

    public double ActualCoverage { get; set; }

    public double ExpectedCoverage { get; set; }

    public int ActualNumberOfContainers { get; set; }

    public int ActualNumberOfVehicles { get; set; }

    public int ActualNumberOfWorkers { get; set; }

    public bool IsMunicipalityCompleted { get; set; }

    public bool IsTransporterCompleted { get; set; }

    public int ActualNumberOfOperationPlans { get; set; }

    public int NumberOfOperationPlans { get; set; }

    public int Capacity { get; set; }

    public int NumberOfRepetitionsPerDay { get; set; }

    public bool IsMonthly { get; set; }

    public int? ServiceFrequencyPerMonth { get; set; }

    [InverseProperty("ContractService")]
    public virtual ICollection<ContractDetailsFile> ContractDetailsFiles { get; set; } = new List<ContractDetailsFile>();

    [ForeignKey("ContractServiceId")]
    [InverseProperty("ContractDetail")]
    public virtual ContractService ContractService { get; set; } = null!;
}
