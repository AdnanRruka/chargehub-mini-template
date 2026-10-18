var station = new ChargingStation { Id = 1, Name = "Torget", MaxKw = 11, PricePerKwh = 3.50m };

var queue = new ChargingQueue();
queue.Add(new Vehicle { Id = 1, BatteryKwh = 82, Percent = 10 });
queue.Add(new Vehicle { Id = 2, BatteryKwh = 75, Percent = 20 });
queue.Add(new Vehicle { Id = 3, BatteryKwh = 60, Percent = 50 });

Console.WriteLine($"{queue.Count} bilar i kön");
decimal total = queue.ProcessAll(station);
Console.WriteLine($"Totalt: {total:F2} kr");

var stations = new List<ChargingStation>
{
    station,
    new ChargingStation { Id = 2, MaxKw = 150, PricePerKwh = 5.00m }
};

foreach (var s in stations)
{
    Console.WriteLine(s.Describe());
}
