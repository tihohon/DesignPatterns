namespace Decorator.Logger;

public class LogToFile : LoggerDecorator
{
    private readonly string _path;
    public LogToFile(string path)
    {
        _path = path;
    }

    public override void Log(string logMessage)
    {
        base.Log(logMessage);
        using var txtWriter = File.AppendText(_path);
        txtWriter.Write("\r\nLog Entry : ");
        txtWriter.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
            DateTime.Now.ToLongDateString());
        txtWriter.WriteLine("  :");
        txtWriter.WriteLine("  :{0}", logMessage);
        txtWriter.WriteLine("-------------------------------");
    }
}