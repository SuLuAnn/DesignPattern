namespace DesignPattern.Observer
{
    public interface ISubject
    {
        public abstract void RegisterObserver(IObserver observer);

        public abstract void RemoveObserver(IObserver observer);

        public abstract void NotifyObserver();
    }
}
