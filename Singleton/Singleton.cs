namespace Singleton;

public class Singleton
{
    private static Singleton? _singleton;
    public string Name { get; set; }

    private Singleton()
    {
        Name = "LiterallyMe";
    }

    public static Singleton GetInstance()
    {
        _singleton ??= new Singleton();
        return _singleton;
    }
}