namespace DesignPattern.Composite
{
    public class Waitress
    {
        private MenuComponent _menuComponent;
        public Waitress(MenuComponent menuComponent)
        {
            _menuComponent = menuComponent;
        }

        public void PrintMenu()
        {
            _menuComponent.Print();
        }
    }
}
