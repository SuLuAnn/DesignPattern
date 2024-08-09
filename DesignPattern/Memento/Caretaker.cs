namespace DesignPattern.Memento
{
    public class Caretaker
    {
        private readonly Stack<Memo> _memos;

        public Caretaker()
        {
            _memos = new();
        }

        public void AddMemo(Memo memo)
        {
            // memo 一直加有爆掉的風險，最好有數量限制
            _memos.Push(memo);
        }

        public Memo GetMemo()
        {
            if (_memos.Count == 0)
            {
                return null;
            }

            return _memos.Pop();
        }
    }
}
