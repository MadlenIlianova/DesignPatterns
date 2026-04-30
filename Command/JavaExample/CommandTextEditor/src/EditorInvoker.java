import java.util.Stack;

public class EditorInvoker {
    private Stack<ICommand> commandHistory = new Stack<>();

    public void executeCommand(ICommand command) {
        command.execute();
        commandHistory.push(command);
    }

    public void undo() {
        if (!commandHistory.isEmpty()) {
            ICommand command = commandHistory.pop();
            command.undo();
        } else {
            System.out.println("No commands to undo.");
        }
    }
}