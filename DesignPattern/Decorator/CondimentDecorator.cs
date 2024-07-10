namespace DesignPattern.Decorator
{
    public abstract class CondimentDecorator : IBeverage
    {
        protected IBeverage Beverage { get; private set; }

        public CondimentDecorator(IBeverage beverage)
        {
            Beverage = beverage;
        }

        public abstract string GetDescription();

        public abstract decimal Cost();
    }
}
