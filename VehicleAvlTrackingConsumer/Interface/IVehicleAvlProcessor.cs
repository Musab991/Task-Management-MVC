namespace VehicleAvlTrackingConsumer.Interface;
using System;
using System.Threading.Tasks;

public interface IVehicleAvlProcessor
{
    Task ProcessAsync(DateTime start, DateTime end, CancellationToken ct);
}
