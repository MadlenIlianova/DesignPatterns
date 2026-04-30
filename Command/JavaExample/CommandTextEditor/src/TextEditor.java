public class TextEditor {
    private String text = "";

    public void insertText(String newText) {
        text += newText;
        System.out.println("Text: '" + text + "'");
    }

    public void removeText(int count) {
        if (count > text.length()) {
            count = text.length();
        }
        text = text.substring(0, text.length() - count);
        System.out.println("Text: '" + text + "'");
    }

    public String getText() {
        return text;
    }
}