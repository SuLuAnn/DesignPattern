namespace DesignPattern.MVC
{
    public class Controller : IController
    {
        private readonly CalculatorModel _calculatorModel;
        private readonly ScreenView _screenView;

        public Controller(CalculatorModel calculatorModel)
        {
            _calculatorModel = calculatorModel;
            _screenView = new ScreenView(this, calculatorModel);
        }

        public void Command(char c)
        {
            switch (c)
            {
                case '1':
                case '2':
                case '3':
                    string com = c.ToString();
                    _calculatorModel.Input(int.Parse(com));
                    break;
            }
        }

        /// <summary>
        /// 因為我的 View 不是 GUI 介面，所以開這個接口，平常命令是由 GUI 傳入
        /// </summary>
        public void Init()
        {
            _screenView.Display();
            while (true)
            {
                _screenView.Command(Console.ReadKey());
            }
        }
    }
}
