namespace DesignPattern.Composite
{
    public class Meal : MenuComponent
    {
        private string _name;
        private int _price;
        private bool _isVegetarian;

        public Meal(string name, int price, bool isVegetarian)
        {
            _name = name;
            _price = price;
            _isVegetarian = isVegetarian;
        }

        public override string GetName()
        {
            return _name;
        }

        public override int GetPrice()
        {
            return _price;
        }

        public override bool IsVegetarian()
        {
            return _isVegetarian;
        }

        public override void Print()
        {
            Console.WriteLine($"{_name} ${_price} 素食:{_isVegetarian}");
        }
    }
}
