namespace ProtectionProxy
{
    public class Program
    {
        static void Main(string[] args)
        {
            IDocument document = new DocumentProxy("1234");
            document.Display();

            IDocument document1 = new DocumentProxy("7777");
            document1.Display();
        }
    }
}
