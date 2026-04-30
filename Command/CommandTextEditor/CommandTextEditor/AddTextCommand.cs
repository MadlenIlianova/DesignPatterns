namespace CommandTextEditor
{
    public class AddTextCommand : ICommand//Concrete Command
    {
        private TextEditor _textEditor;
        private string _textToAdd;

        public AddTextCommand(TextEditor textEditor, string textToAdd)
        {
            _textEditor = textEditor;
            _textToAdd = textToAdd;
        }

        public void Execute() => _textEditor.InsertText(_textToAdd);
        public void Undo() => _textEditor.RemoveText(_textToAdd.Length);
    }
}
