namespace Decorator.Logger;

public abstract class LoggerDecorator : BaseLogger
{
    private BaseLogger? _logger;

    public void SetLogger(BaseLogger baseLogger)
    {
        _logger = baseLogger;
    }

    public override void Log(string logMessage)
    {
        _logger?.Log(logMessage);
    }
}