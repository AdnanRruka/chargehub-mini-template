# ChargeHub Mini

Startrepo till Labb A i Programmering 2.

Programmet simulerar en laddstation med en kö av bilar. Det bygger, men ger fel resultat
eller kraschar. Din uppgift finns i dokumentet Labb A – Git och felsökning.

## Köra programmet

```
dotnet build
dotnet run
```

Du behöver .NET 10 SDK. Visual Studio Code med C# Dev Kit eller Visual Studio fungerar.

## Filer

| Fil | Innehåll |
| --- | --- |
| `Program.cs` | Skapar station, bilar och kö, och skriver ut resultatet |
| `ChargingStation.cs` | Station med pris och laddning |
| `Vehicle.cs` | Bil med batteri och laddnivå |
| `ChargingQueue.cs` | Kö som laddar bilarna i tur och ordning |
