namespace Observer;

public class WeatherStation : IObservable
{
    private double _degrees;
    private double _pressure;
    private string? _weatherDescription;

    private readonly List<IObserver> _observersToNotify = new();

    public void Add(IObserver observer)
    {
        _observersToNotify.Add(observer);
    }

    public void Remove(IObserver observer)
    {
        _observersToNotify.Remove(observer);
    }

    public void Notify()
    {
        _observersToNotify.ForEach(x => x.Update());
    }

    public void UpdateWeather(double? degrees = null, double? pressure = null, string? weatherDescription = null)
    {
        _degrees = degrees ?? _degrees;
        _pressure = pressure ?? _pressure;
        _weatherDescription = weatherDescription ?? _weatherDescription;
        Notify();
    }

    public double GetDegrees()
    {
        return _degrees;
    }

    public double GetPressure()
    {
        return _pressure;
    }

    public string? GetWeatherDescription()
    {
        return _weatherDescription;
    }
}