namespace DesignPattern.Observer
{
    public interface IObserver
    {
        public abstract void Update(float temperature, float pressure);
    }
}
