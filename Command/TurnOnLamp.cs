namespace Command;

public class TurnOnLamp : ICommand
{
    private readonly Lamp _lamp;

    public TurnOnLamp(Lamp lamp)
    {
        _lamp = lamp;
    }

    public void Execute()
    {
        _lamp.TurnOn();
    }

    public void UnExecute()
    {
        _lamp.TurnOff();
    }
}