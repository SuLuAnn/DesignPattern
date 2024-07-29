namespace DesignPattern.Observer
{
    public class MainDisplay : IObserver, IDisplayElement
    {
        private float _temperature;

        private float _pressure;

        public void Display()
        {
            Console.WriteLine($"首頁當前溫度: {_temperature} 壓力: {_pressure}");
        }

        public void Update(float temperature, float pressure)
        {
            _temperature = temperature;
            _pressure = pressure;
            Display();
        }
    }
}
