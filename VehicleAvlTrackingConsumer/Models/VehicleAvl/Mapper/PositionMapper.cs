using VehicleAvlTrackingConsumer.Models.VehicleAvl.Dto;

namespace VehicleAvlTrackingConsumer.Models.VehicleAvl.Mapper
{
    public static class PositionMapper
    {
        public static PositionDto MapFromTcPosition(TcPosition tc)
        {
            if (tc == null) return null!;

            var positionDto = new PositionDto
            {
                id = tc.Id,
                deviceTime = tc.Devicetime,
                latitude = tc.Latitude,
                longitude = tc.Longitude,
                altitude = tc.Altitude,
                speed = tc.Speed,
                attributes = new PositionAttributesDto()
            };

            if (!string.IsNullOrEmpty(tc.Attributes))
            {
                try
                {
                    var attr = System.Text.Json.JsonSerializer.Deserialize<PositionAttributesDto>(tc.Attributes);
                    if (attr != null)
                        positionDto.attributes = attr;
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }

            return positionDto;
        }
    }

}
