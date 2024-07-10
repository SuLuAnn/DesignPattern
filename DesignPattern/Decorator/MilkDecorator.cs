namespace DesignPattern.Decorator
{
    public class MilkDecorator : CondimentDecorator
    {
        public MilkDecorator(IBeverage beverage) : base(beverage)
        {
        }

        public override string GetDescription()
        {
            return $"{Beverage.GetDescription()}, Milk";
        }

        public override decimal Cost()
        {
            return Beverage.Cost() + 0.5m;
        }
    }
}
