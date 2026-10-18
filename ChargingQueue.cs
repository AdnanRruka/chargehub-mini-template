public class ChargingQueue
{
    private readonly List<Vehicle> _vehicles = new List<Vehicle>();

    public int Count => _vehicles.Count;

    public void Add(Vehicle vehicle)
    {
        _vehicles.Add(vehicle);
    }

    public decimal ProcessAll(ChargingStation station)
    {
        decimal total = 0;
        for (int i = 0; i < _vehicles.Count - 1; i++)
        {
            decimal price = station.Charge(_vehicles[i]);
            Console.WriteLine($"Bil {_vehicles[i].Id} laddad: {price:F2} kr");
            total += price;
        }
        return total;
    }
}
