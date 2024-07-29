namespace DesignPattern.Observer
{
    public class WeatherData : ISubject
    {
        private float _temperature;

        private float _pressure;

        private readonly List<IObserver> _observers;

        public void Change(float temperature, float pressure)
        {
            _temperature = temperature;
            _pressure = pressure;
            Console.WriteLine("溫度及壓力改變了");
            NotifyObserver();
        }

        public WeatherData()
        {
            _observers = new List<IObserver>();
        }

        public void NotifyObserver()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_temperature, _pressure);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }
    }
}
