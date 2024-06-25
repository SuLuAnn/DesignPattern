namespace DesignPattern.Singleton
{
    /// <summary>
    /// 在非多執行緒環境下，永遠取得相同實例
    /// 惰性建立實例，避免耗費大量資源的物件建立卻沒使用
    /// </summary>
    public class SingletonBase
    {
        private static SingletonBase? _singleton;

        public static SingletonBase GetSingleton()
        {
            if (_singleton == null)
            {
                _singleton = new SingletonBase();
            }
            return _singleton;
        }
        private SingletonBase() { }
    }
}
