using DefaultNamespace;

namespace Proxy;

public class KnapClientProxy : IKnapClient
{
    private readonly IKnapClient _knapClient;
    private string? _cachedData;

    public KnapClientProxy(IKnapClient knapClient)
    {
        _knapClient = knapClient;
    }

    public string GetExpensiveData()
    {
        return _cachedData ??= _knapClient.GetExpensiveData();
    }

    public void Recache()
    {
        _cachedData = _knapClient.GetExpensiveData();
    }
    
}