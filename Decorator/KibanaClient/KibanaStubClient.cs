namespace Decorator.KibanaClient;

public class KibanaStubClient : IKibanaClient
{
    public string SendedData = "";
    
    public void SendLog(string log)
    {
        SendedData += log;
    }
}