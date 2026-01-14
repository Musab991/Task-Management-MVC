namespace VehicleAvlTrackingConsumer.Service.Processor.State;

public class AvlProcessingState
{
    public bool IsRunning { get; set; }
    public DateTime? Start { get; set; }
    public DateTime? End { get; set; }
    public DateTime? LastProcessedDeviceTime { get; set; }
}
