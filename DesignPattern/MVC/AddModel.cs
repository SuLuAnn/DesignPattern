namespace DesignPattern.MVC
{
    public class AddModel : CalculatorModel
    {
        public override void Input(int num)
        {
            _total += num;
            NotifyObserver();
        }

        public override int Output()
        {
            return _total;
        }
    }
}
