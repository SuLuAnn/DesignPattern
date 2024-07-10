namespace DesignPattern.Decorator
{
    public class Decaf : IBeverage
    {

        public string GetDescription()
        {
            return "Decaf";
        }

        public decimal Cost()
        {
            return 12m;
        }
    }
}
