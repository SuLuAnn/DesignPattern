namespace DesignPattern.MVC
{
    public class ScreenView : IView, IDisplayObserver
    {
        private readonly IController _controller;

        private readonly CalculatorModel _calculatorModel;

        private string _screenNum;

        public ScreenView(
            IController controller,
            CalculatorModel calculatorModel)
        {
            _controller = controller;
            _calculatorModel = calculatorModel;
            _calculatorModel.RegisterObserver(this);
            _screenNum = "0";
        }

        public void Command(ConsoleKeyInfo c)
        {
            _controller.Command(c.KeyChar);
        }

        public void Display()
        {
            Console.WriteLine($"結果: {_screenNum}");
        }

        public void Update(int total)
        {
            _screenNum = total.ToString();
            Display();
        }
    }
}
