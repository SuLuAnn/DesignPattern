namespace DesignPattern.Decorator
{
    public class Espresso : IBeverage
    {
        public string GetDescription()
        {
            return "Espresso";
        }

        public decimal Cost()
        {
            return 10m;
        }
    }
}
