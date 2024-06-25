namespace DesignPattern.Singleton
{
    public class SingletonProgram
    {
        public void Main()
        {
            // 執行緒不安全
            var singleton = SingletonBase.GetSingleton();

            // 用lock
            var singletonLock = SingletonLock.GetSingleton();

            // 一開始就建立唯一實例
            var singletonEager = SingletonEager.GetSingleton();

            // 用Lazy
            var singletonLazy = SingletonLazy.GetSingleton();
        }
    }
}
