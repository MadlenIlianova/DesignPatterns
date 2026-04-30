namespace CommandTextEditor
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
