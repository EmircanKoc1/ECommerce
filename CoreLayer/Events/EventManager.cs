using CoreLayer.Delegates;

namespace CoreLayer.Events;

public class CacheEventManager
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
