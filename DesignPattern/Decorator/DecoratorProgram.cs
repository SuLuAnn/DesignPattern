namespace DesignPattern.Decorator
{
    public class DecoratorProgram
    {
        public void Main()
        {
            var beverage1 = new MilkDecorator(new MilkDecorator(new Decaf()));
            Console.WriteLine($"{beverage1.GetDescription()}. ${beverage1.Cost()}");

            var beverage2 = new MilkDecorator(new WhipDecorator(new Espresso()));
            Console.WriteLine($"{beverage2.GetDescription()}. ${beverage2.Cost()}");
        }
    }
}
