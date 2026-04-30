public class AddTextCommand implements ICommand {
    private TextEditor textEditor;
    private String textToAdd;

    public AddTextCommand(TextEditor textEditor, String textToAdd) {
        this.textEditor = textEditor;
        this.textToAdd = textToAdd;
    }

    @Override
    public void execute() {
        textEditor.insertText(textToAdd);
    }

    @Override
    public void undo() {
        textEditor.removeText(textToAdd.length());
    }
}