namespace DesignPattern.Composite
{
    public class CompositeProgram
    {
        public void Main()
        {
            var dinnerComponent = new Menu("情人節特餐");
            dinnerComponent.Add(new Meal("火雞", 100, false));
            dinnerComponent.Add(new Meal("沙拉", 10, true));
            var dessertMenu = new Menu("巧克力組合");
            dessertMenu.Add(new Meal("巧克力蛋糕", 5, false));
            dinnerComponent.Add(dessertMenu);

            var waitress = new Waitress(dinnerComponent);

            Console.WriteLine("印出全部");

            waitress.PrintMenu();
        }
    }
}
