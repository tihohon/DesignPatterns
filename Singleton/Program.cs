var singleton = Singleton.Singleton.GetInstance();
Console.WriteLine(singleton.Name);
singleton.Name = "LitteralyYou";
var otherSingleton = Singleton.Singleton.GetInstance();
Console.WriteLine(otherSingleton.Name);