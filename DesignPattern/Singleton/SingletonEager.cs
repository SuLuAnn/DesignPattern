namespace DesignPattern.Singleton
{
    /// <summary>
    /// 急性建立
    /// </summary>
    public class SingletonEager
    {
        private readonly static SingletonEager _singleton = new SingletonEager();

        public static SingletonEager GetSingleton()
        {
            return _singleton;
        }
        private SingletonEager() { }
    }
}
