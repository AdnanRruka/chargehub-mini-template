public class Vehicle
{
    public int Id { get; set; }
    public int BatteryKwh { get; set; }
    public int Percent { get; set; }

    public bool IsCharged => Percent == 100;
}
