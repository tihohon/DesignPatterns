using DefaultNamespace;

namespace Proxy;

public class KnapClient : IKnapClient
{
    public string GetExpensiveData()
    {
        Thread.Sleep(3000);
        return "The Data";
    }
}