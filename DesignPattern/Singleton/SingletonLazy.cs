namespace DesignPattern.Singleton
{
    /// <summary>
    /// 使用 Lazy 確保為惰性建立
    /// </summary>
    public class SingletonLazy
    {
        private readonly static Lazy<SingletonLazy> _singleton = new Lazy<SingletonLazy>(() => new SingletonLazy());

        public static SingletonLazy GetSingleton()
        {
            return _singleton.Value;
        }

        private SingletonLazy() { }
    }
}
