namespace CommandSmartHouse
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
