namespace DesignPattern.Template
{
    public class Tea : Beverage
    {
        public override void AddCondiments()
        {
            Console.WriteLine("加糖");
        }

        public override void Brew()
        {
            Console.WriteLine("泡茶");
        }
    }
}
