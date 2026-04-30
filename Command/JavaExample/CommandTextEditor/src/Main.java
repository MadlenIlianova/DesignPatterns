void main(String[] args) {
        TextEditor editor = new TextEditor();
        EditorInvoker invoker = new EditorInvoker();

        // Изпълнение на команди
        invoker.executeCommand(new AddTextCommand(editor, "Hello, "));
        invoker.executeCommand(new AddTextCommand(editor, "World"));
        invoker.executeCommand(new AddTextCommand(editor, "!"));

        System.out.println("\nPressing undo 2 times:");
        invoker.undo();
        invoker.undo();
}
