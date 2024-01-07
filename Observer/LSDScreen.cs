namespace Observer;

public class LSDScreen : IObserver
{
    private readonly WeatherStation _weatherStation;

    public LSDScreen(WeatherStation weatherStation)
    {
        _weatherStation = weatherStation;
    }

    public void Update()
    {
        var degrees = _weatherStation.GetDegrees();
        var pressure = _weatherStation.GetPressure();
        var description = _weatherStation.GetWeatherDescription();
        Console.WriteLine($"------------------------------------------");
        Console.WriteLine($"same but different");
        Console.WriteLine($"degrees: {degrees}\npressure: {pressure}\ndescription: {description}\n");
    }
}