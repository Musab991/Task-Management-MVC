using System;
using System.Collections.Generic;

namespace VehicleAvlTrackingConsumer.Models.QA;

public partial class ContractDetail
{
    public Guid Id { get; set; }

    public int? ServiceFrequency { get; set; }

    public double AcceptanceRateOfOperationalPlans { get; set; }

    public int NumberOfVehicles { get; set; }

    public int NumberOfContainers { get; set; }

    public int NumberOfWorkers { get; set; }

    public Guid ContractServiceId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

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

    public virtual ICollection<ContractDetailsFile> ContractDetailsFiles { get; set; } = new List<ContractDetailsFile>();

    public virtual ContractService ContractService { get; set; } = null!;
}
