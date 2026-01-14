using Microsoft.Extensions.Diagnostics.HealthChecks;
using VehicleAvlTrackingConsumer.Cache;
using VehicleAvlTrackingConsumer.Configuration;
using VehicleAvlTrackingConsumer.Interface;
using VehicleAvlTrackingConsumer.Service.Processor;
using VehicleAvlTrackingConsumer.Service.Processor.Background;
using VehicleAvlTrackingConsumer.Service.Processor.State;

var builder = WebApplication.CreateBuilder(args);

// --------------------
// Configuration
// --------------------
builder.Configuration
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

// --------------------
// Services
// --------------------
builder.Services.AddDatabaseServices(builder.Configuration);
builder.Services.AddHostedService<AvlBackgroundWorker>();
builder.Services.AddSingleton<AvlProcessingState>();

builder.Services.AddMemoryCache();

builder.Services.AddSingleton<VehicleCache>();
builder.Services.AddSingleton<DeviceCache>();


builder.Services.AddScoped<IVehicleAvlProcessor, VehicleAvlProcessor>();


builder.Services.AddHealthChecks()
    .AddCheck("avl-worker", () =>
        HealthCheckResult.Healthy("AVL worker is running"));

// --------------------
// Build app
// --------------------
var app = builder.Build();

// --------------------
// Minimal API endpoint
// --------------------

app.MapHealthChecks("/health");

app.MapPost("/process-avl", (
    DateTime start,
    DateTime end,
    AvlProcessingState state) =>
{
    if (state.IsRunning)
    {
        return Results.BadRequest(new
        {
            message = "AVL processing is already running",
            runningStart = state.Start,
            runningEnd = state.End
        });

    }

    state.Start = start;
    state.End = end;
    state.IsRunning = true;

    return Results.Accepted(
     uri: "/process-avl", 
     value: new
     {
         message = "AVL processing started",
         start,
         end
     });


});

// --------------------
app.Run();
