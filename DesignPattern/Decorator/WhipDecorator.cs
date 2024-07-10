namespace DesignPattern.Decorator
{
    public class WhipDecorator : CondimentDecorator
    {
        public WhipDecorator(IBeverage beverage) : base(beverage)
        {
        }

        public override string GetDescription()
        {
            return $"{Beverage.GetDescription()}, Whip";
        }

        public override decimal Cost()
        {
            return Beverage.Cost() + 1m;
        }
    }
}
