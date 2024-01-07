namespace Strategy;

public class Duck
{
    private readonly IFlying _fly;

    public Duck(IFlying fly)
    {
        _fly = fly;
    }

    public void Migrate()
    {
        Console.WriteLine("Wake Up");
        _fly.Fly();
        Console.WriteLine("Drop Down");
    }
}