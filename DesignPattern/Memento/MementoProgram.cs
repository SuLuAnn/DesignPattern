namespace DesignPattern.Memento
{
    public class MementoProgram
    {
        public void Main()
        {
            var note = new Note();
            var caretaker = new Caretaker();
            note.AddChar('H');
            note.AddChar('i');
            caretaker.AddMemo(note.SaveMemo());
            note.AddChar('!');
            caretaker.AddMemo(note.SaveMemo());
            note.AddChar(' ');
            note.AddChar('I');
            note.OutputDoc();
            note.RestoreMemo(caretaker.GetMemo());
            note.OutputDoc();
            note.RestoreMemo(caretaker.GetMemo());
            note.OutputDoc();
        }
    }
}
