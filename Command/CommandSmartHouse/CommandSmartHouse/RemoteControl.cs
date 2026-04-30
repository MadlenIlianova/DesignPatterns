namespace CommandSmartHouse
{
    public class RemoteControl //Invoker
    {
        private Stack<ICommand> _commandsHistory = new Stack<ICommand>();

        public void PressButton(ICommand command)
        {
            command.Execute();
            _commandsHistory.Push(command);
        }

        public void PressUndo()
        {
            if (_commandsHistory.Count > 0)
            {
                ICommand lastCommand = _commandsHistory.Pop();
                lastCommand.Undo();
            }
            else
            {
                Console.WriteLine("No commands to undo.");
            }
        }
    }
}
