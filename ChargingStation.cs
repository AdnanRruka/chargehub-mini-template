public class ChargingStation
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double MaxKw { get; set; }
    public decimal PricePerKwh { get; set; }

    public string Describe()
    {
        return $"Station {Id}: {Name.ToUpper()} ({MaxKw} kW)";
    }

    public decimal CalculatePrice(Vehicle vehicle)
    {
        return vehicle.BatteryKwh * (100 - vehicle.Percent) / 100 * PricePerKwh;
    }

    public decimal Charge(Vehicle vehicle)
    {
        decimal price = CalculatePrice(vehicle);
        vehicle.Percent = 100;
        return price;
    }
}
