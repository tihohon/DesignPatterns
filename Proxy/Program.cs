using Proxy;

var knapClient = new KnapClient();
var knapClientWithCache = new KnapClientProxy(knapClient);
knapClientWithCache.GetExpensiveData();
Console.WriteLine("firstQueryFinished");
knapClientWithCache.GetExpensiveData();
Console.WriteLine("secondQueryFinished");