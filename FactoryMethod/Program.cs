// See https://aka.ms/new-console-template for more information
using FactoryMethod;

AnimalFactory GetRandomWayToCreateAnimal()
{
    var random = new Random();
    if (random.Next(1, 3) == 1)
        return new GodFactory();
    return new FamilyFactory(Guid.NewGuid(), Guid.NewGuid());
};

var factory = GetRandomWayToCreateAnimal();

Console.WriteLine(factory.GetType());
var randomAnimal = factory.Create();
Console.WriteLine(randomAnimal.SaySound());
Console.WriteLine(randomAnimal.GetDescription());
