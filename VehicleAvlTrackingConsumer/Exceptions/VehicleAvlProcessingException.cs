namespace VehicleAvlTrackingConsumer.Exceptions;


public class VehicleAvlProcessingException : Exception
{
    public DateTime? LastProcessedDeviceTime { get; }

    public VehicleAvlProcessingException(string message, Exception inner, DateTime? lastProcessedDeviceTime)
        : base(message, inner)
    {
        LastProcessedDeviceTime = lastProcessedDeviceTime;
    }
}

