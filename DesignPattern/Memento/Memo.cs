namespace DesignPattern.Memento
{
    public class Memo
    {
        public Memo(string doc)
        {
            Doc = doc;
        }
        public string Doc { get; private set; }
    }
}
