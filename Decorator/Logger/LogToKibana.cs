using Decorator.KibanaClient;

namespace Decorator.Logger;

public class LogToKibana : LoggerDecorator
{
    private readonly IKibanaClient _kibanaClient;

    public LogToKibana(IKibanaClient kibanaClient)
    {
        _kibanaClient = kibanaClient;
    }

    public override void Log(string logMessage)
    {
        _kibanaClient.SendLog(logMessage);
        base.Log(logMessage);
    }
}