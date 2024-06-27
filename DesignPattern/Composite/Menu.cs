namespace DesignPattern.Composite
{
    public class Menu : MenuComponent
    {
        private string _name;
        private List<MenuComponent> _menuComponents;

        public Menu(string name)
        {
            _name = name;
            _menuComponents = new List<MenuComponent>();
        }

        public override string GetName()
        {
            return _name;
        }

        public override void Add(MenuComponent menuComponent)
        {
            _menuComponents.Add(menuComponent);
        }

        public override void Remove(MenuComponent menuComponent)
        {
            _menuComponents.Remove(menuComponent);
        }

        public override MenuComponent GetChild(int index)
        {
            return _menuComponents[index];
        }

        public override void Print()
        {
            Console.WriteLine(_name);
            foreach (MenuComponent menuComponent in _menuComponents)
            {
                menuComponent.Print();
            }
        }
    }
}
