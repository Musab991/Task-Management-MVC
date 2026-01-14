namespace VehicleAvlTrackingConsumer.Models.Jadeh_Development;

class VehicleAvlDatumComparer : IEqualityComparer<VehiclesAvlDatum>
{


    public bool Equals(VehiclesAvlDatum x, VehiclesAvlDatum y)
    {
        if (x is null || y is null)
            return false;

        return
                (x.Tag == y.Tag)
             && (x.Imei == y.Imei)
             && (x.Speed == y.Speed)
             && (x.Longitude == y.Longitude)
             && (x.Latitude == y.Latitude)
             && (x.Ignition == y.Ignition);

    }

    public int GetHashCode(VehiclesAvlDatum obj)
    {
        return HashCode.Combine(obj.Tag, obj.Imei, obj.Speed, obj.Longitude, obj.Latitude, obj.Ignition);
    }


}


