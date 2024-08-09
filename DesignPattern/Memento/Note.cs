namespace DesignPattern.Memento
{
    public class Note
    {
        private string _doc;

        public Note()
        {
            _doc = string.Empty;
        }

        public void AddChar(char c)
        {
            _doc += c;
        }

        public void OutputDoc()
        {
            Console.WriteLine(_doc);
        }

        public Memo SaveMemo()
        {
            return new Memo(_doc);
        }

        public void RestoreMemo(Memo memo)
        {
            if (memo != null)
            {
                _doc = memo.Doc;
            }
        }
    }
}
