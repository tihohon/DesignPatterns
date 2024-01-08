namespace FactoryMethod;

public abstract class Animal
{
    public Guid Id;
    public string Name;
    public Guid? Parent1;
    public Guid? Parent2;
    public double Height;

    protected Animal(string name, Guid? parent1, Guid? parent2, double height)
    {
        Name = name;
        Parent1 = parent1;
        Parent2 = parent2;
        Height = height;
        Id = Guid.NewGuid();
    }

    public string GetDescription()
    {
        return $"Id: {Id}\nName: {Name}\nParents:{Parent1}, {Parent2}\nHeight: {Height}\n";
    }

    public abstract string SaySound();
}