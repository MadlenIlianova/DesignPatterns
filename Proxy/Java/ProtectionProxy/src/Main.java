void main() {
    IDocument document = new DocumentProxy("1234");
    document.display();

    IDocument document1 = new DocumentProxy("7777");
    document1.display();
}
