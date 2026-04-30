namespace CommandTextEditor
{
    public class Program
    {
        static void Main(string[] args)
        {
            var editor = new TextEditor();
            var invoker = new EditorInvoker();

            invoker.ExecuteCommand(new AddTextCommand(editor, "Hello,"));
            invoker.ExecuteCommand(new AddTextCommand(editor, "World"));
            invoker.ExecuteCommand(new AddTextCommand(editor, "!"));

            Console.WriteLine("Pressing undo 2 times:");
            invoker.Undo();
            invoker.Undo();
        }
    }
}
