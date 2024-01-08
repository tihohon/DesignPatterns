namespace FactoryMethod;

public class Wolf : Animal
{
    public Wolf(string name, Guid? parent1, Guid? parent2, double height) : base(name, parent1, parent2, height)
    {
    }

    public override string SaySound()
    {
        return "WUF"; //i don't care
    }
}