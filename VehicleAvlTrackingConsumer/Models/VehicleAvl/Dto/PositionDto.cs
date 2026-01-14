namespace VehicleAvlTrackingConsumer.Models.VehicleAvl.Dto;
public class PositionDto
{
    public int id { get; set; } = 0;
    public PositionAttributesDto? attributes { get; set; } = new PositionAttributesDto();
    public DateTime deviceTime { get; set; } = DateTime.Now;
    public double? latitude { get; set; } = null;
    public double? longitude { get; set; } = null;
    public double? altitude { get; set; } = null;
    public double? speed { get; set; } = null;
    public string? Imei { get; set; } = null;
}
