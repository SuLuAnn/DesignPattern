namespace DesignPattern.Template
{
    public class Coffee : Beverage
    {
        public override void AddCondiments()
        {
            Console.WriteLine("加牛奶");
        }

        public override void Brew()
        {
            Console.WriteLine("泡咖啡");
        }

        public override void LatteArt()
        {
            Console.WriteLine("拉貓貓形狀拉花");
        }
    }
}
