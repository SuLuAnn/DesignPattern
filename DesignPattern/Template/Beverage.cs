namespace DesignPattern.Template
{
    public abstract class Beverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
            LatteArt();
        }

        public void BoilWater()
        {
            Console.WriteLine("燒水");
        }

        public abstract void Brew();

        public void PourInCup()
        {
            Console.WriteLine("倒入杯子");
        }

        public abstract void AddCondiments();

        /// <summary>
        /// 這是 hook，讓子類別自己決定要不要覆寫
        /// </summary>
        public virtual void LatteArt()
        { }
    }
}
