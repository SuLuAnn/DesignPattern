namespace DesignPattern.Singleton
{
    /// <summary>
    /// 執行緒安全
    /// 如果GetSingleton()常呼叫，效能不好
    /// </summary>
    public class SingletonLock
    {
        private static SingletonLock? _singleton;
        private static readonly Object _lock = new();

        public static SingletonLock GetSingleton()
        {
            lock (_lock)
            {
                if (_singleton == null)
                {
                    _singleton = new SingletonLock();
                }
            }
            return _singleton;
        }
        private SingletonLock() { }
    }
}
