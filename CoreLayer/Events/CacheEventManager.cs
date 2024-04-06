using CoreLayer.Delegates;
using CoreLayer.Events.Abstract;

namespace CoreLayer.Events;

public class CacheEventManager : ICacheEventManager
{

    public CacheEventManager()
    => CacheRefreshEvent += () =>
        {
            //ilgili kodu buraya yazarım
        };

    private static object locker = new();

    private event CacheHandler CacheRefreshEvent;
    public void TriggerEvent()
    {
        lock (locker)
        {
            CacheRefreshEvent.Invoke();
        }
    }



}
