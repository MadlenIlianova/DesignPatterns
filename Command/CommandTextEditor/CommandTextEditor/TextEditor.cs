namespace CommandTextEditor
{
    public class TextEditor // Receiver
    {
        private string _text = "";

        public void InsertText(string text)
        {
            _text += text;
            Console.WriteLine($"Text:'{_text}'");
        }

        public void RemoveText(int count)
        {
            if (count > _text.Length)
            {
                count = _text.Length;
            }
            _text = _text.Substring(0, _text.Length - count);
            Console.WriteLine($"Text:'{_text}'");
        }

        public string GetText() => _text;
    }
}