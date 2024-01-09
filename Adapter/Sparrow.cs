namespace Adapter;

public class Sparrow : IBird
{
    public void Cry()
    {
        Console.WriteLine("FUCK ME");
    }

    public void Fly()
    {
        Console.WriteLine("I FLY SO HIGH TO FALL SO LOW");
    }
}