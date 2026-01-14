namespace VehicleAvlTrackingConsumer.Models.VehicleAvl.Dto;

public class PositionAttributesDto
{
    internal float io9 { get; set; } = 0;
    public bool? in1 { get; set; } = null;
    public bool? in2 { get; set; } = null;
    public bool? in3 { get; set; } = null;
    public bool? in4 { get; set; } = null;

    public string? io109 { get; set; } = "-1"; // Tag
    public double? power { get; set; } = null;
    public double? distance { get; set; } = null;
    public double? totalDistance { get; set; } = null;
    public int? priority { get; set; } = null;
    public bool? motion { get; set; } = null;
    public bool? ignition { get; set; } = null;

}