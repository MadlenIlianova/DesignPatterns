public class DocumentProxy implements IDocument{
    private SecretDocument secretDocument;
    private String password;

    public DocumentProxy(String password) {
        this.password = password;
    }

    @Override
    public void display() {
        if ("1234".equals(this.password)) {
            if (secretDocument == null) {
                secretDocument = new SecretDocument();
            }
            secretDocument.display();
        } else {
            System.out.println("Access denied: Incorrect password.");
        }
    }
}
