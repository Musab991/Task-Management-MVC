namespace VehicleAvlTrackingConsumer.Service.Processor.Background;

using VehicleAvlTrackingConsumer.Exceptions;
using VehicleAvlTrackingConsumer.Interface;
using VehicleAvlTrackingConsumer.Service.Processor.State;

public class AvlBackgroundWorker : BackgroundService
{
    private readonly ILogger<AvlBackgroundWorker> _logger;
    private readonly IServiceScopeFactory _scopeFactory;
    private readonly AvlProcessingState _state;

    public AvlBackgroundWorker(
        ILogger<AvlBackgroundWorker> logger,
        IServiceScopeFactory scopeFactory,
        AvlProcessingState state)
    {
        _logger = logger;
        _scopeFactory = scopeFactory;
        _state = state;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _logger.LogInformation("AVL Background Worker started");

        while (!stoppingToken.IsCancellationRequested)
        {
            if (!_state.IsRunning || _state.Start == null || _state.End == null)
            {
                await Task.Delay(1000, stoppingToken);
                continue;
            }

            try
            {
             
                using var scope = _scopeFactory.CreateScope();
                
                var processor = scope.ServiceProvider
                    .GetRequiredService<IVehicleAvlProcessor>();

                _logger.LogInformation(
                 "AVL processing started: {Start} -> {End}",
                 _state.Start, _state.End);

                await processor.ProcessAsync(
                    _state.Start.Value,
                    _state.End.Value,
                    stoppingToken);

                _logger.LogInformation("AVL processing completed");

            }
            catch (VehicleAvlProcessingException ex)
            {

                _logger.LogWarning($"AVL processing failed. Last processed device time: {ex.LastProcessedDeviceTime}");

                _logger.LogError(ex, "AVL processing failed.");

                _state.LastProcessedDeviceTime = ex.LastProcessedDeviceTime;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "AVL processing failed unexpectedly");
            }
            finally
            {
                _state.IsRunning = false;
            }
        }
    }
}
