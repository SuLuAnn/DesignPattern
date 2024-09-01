namespace DesignPattern.MVC
{
    public class CalculateProgram
    {
        public void Main()
        {
            CalculatorModel model = new AddModel();
            IController controller = new Controller(model);
            controller.Init();
        }
    }
}
