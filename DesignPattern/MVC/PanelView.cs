namespace DesignPattern.MVC
{
    public class PanelView : IView
    {
        private List<IView> _views;

        public void Add(IView view)
        {
            _views.Add(view);
        }

        public void Remove(IView view)
        {
            _views.Remove(view);
        }

        public void Display()
        {
            Console.WriteLine("面板已顯示");
            foreach (var view in _views)
            {
                view.Display();
            }
        }
    }
}
