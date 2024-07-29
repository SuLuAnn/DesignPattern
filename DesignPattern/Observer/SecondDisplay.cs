namespace DesignPattern.Observer
{
    public class SecondDisplay : IObserver, IDisplayElement
    {
        private float _temperature;

        public void Display()
        {
            Console.WriteLine($"第二畫面當前溫度: {_temperature}");
        }

        /// <summary>
        /// 另一種寫法會在 WeatherData 留接口，觀察者被通知後依據需求能資料，這
        /// 樣加參數的時候要動的觀察者就只有需要該參數得而已
        /// </summary>
        /// <param name="temperature"></param>
        /// <param name="pressure"></param>
        public void Update(float temperature, float pressure)
        {
            _temperature = temperature;
            Display();
        }
    }
}
