namespace Observer;

public class LSDScreen : IObserver, IDisplay
{
    private readonly WeatherStation _weatherStation;
    private double _degrees;
    private double _pressure;
    private string? _weather_description;

    public LSDScreen(WeatherStation weatherStation)
    {
        _weatherStation = weatherStation;
    }

    public void Update()
    {
        var degrees = _weatherStation.GetDegrees();
        var pressure = _weatherStation.GetPressure();
        var description = _weatherStation.GetWeatherDescription();
        _degrees = degrees;
        _pressure = pressure;
        _weather_description = description;
    }
    public void Display()
    {
        Console.WriteLine($"------------------------------------------");
        Console.WriteLine($"same but different");
        Console.WriteLine($"degrees: {_degrees}\npressure: {_pressure}\ndescription: {_weather_description}\n");
    }
}