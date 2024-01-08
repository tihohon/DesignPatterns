namespace FactoryMethod;

public class Duck : Animal
{
    public Duck(string name, Guid? parent1, Guid? parent2, double height) : base(name, parent1, parent2, height)
    {
    }

    public override string SaySound()
    {
        return "KRYAAA!!"; //i don't care
    }
}