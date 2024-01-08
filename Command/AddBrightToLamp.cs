namespace Command;

public class AddBrightToLamp : ICommand
{
    private readonly Lamp _lamp;

    public AddBrightToLamp(Lamp lamp)
    {
        _lamp = lamp;
    }

    public void Execute()
    {
        _lamp.AddBright(20);
    }

    public void UnExecute()
    {
        _lamp.SubtractBright(20);

    }
}