namespace DesignPattern.Observer
{
    public class ObserverProgram
    {
        public void Main()
        {
            WeatherData weatherData = new WeatherData();

            weatherData.Change(1, 1);

            IObserver observerA = new MainDisplay();
            IObserver observerB = new SecondDisplay();

            weatherData.RegisterObserver(observerA);
            weatherData.RegisterObserver(observerB);

            weatherData.Change(10, 2);

            weatherData.RemoveObserver(observerA);

            weatherData.Change(5, 8);
        }
    }
}
