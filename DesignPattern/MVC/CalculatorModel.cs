namespace DesignPattern.MVC
{
    public abstract class CalculatorModel
    {
        protected int _total;
        private readonly List<IDisplayObserver> _observers;

        public CalculatorModel()
        {
            _observers = new List<IDisplayObserver>();
        }
        public abstract void Input(int num);

        public abstract int Output();

        public void RegisterObserver(IDisplayObserver o)
        {
            _observers.Add(o);
        }

        public void RemoveObserver(IDisplayObserver o)
        {
            _observers.Remove(o);
        }

        protected void NotifyObserver()
        {
            foreach (IDisplayObserver observer in _observers)
            {
                observer.Update(_total);
            }
        }
    }
}
