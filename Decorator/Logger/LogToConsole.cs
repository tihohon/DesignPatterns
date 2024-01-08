namespace Decorator.Logger;

public class LogToConsole : LoggerDecorator
{
    public override void Log(string logMessage)
    {
        base.Log(logMessage);
        Console.WriteLine("---------------------\n");
        Console.WriteLine(logMessage + "\n");
    }
}