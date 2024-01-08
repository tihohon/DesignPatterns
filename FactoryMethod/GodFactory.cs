namespace FactoryMethod;

public class GodFactory : AnimalFactory
{
    public override Animal Create()
    {
        var random = new Random();
        if (random.Next(1, 3) == 1)
            return new Duck("GodName", null, null, 44);
        return new Wolf("GodName", null, null, 44);
    }
}