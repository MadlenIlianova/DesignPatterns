namespace ProtectionProxy
{
    public class DocumentProxy : IDocument
    {
        private SecretDocument _secretDocument;
        private string _password;

        public DocumentProxy(string password)
        {
            _password = password;
        }

        public void Display()
        {
            if (_password == "1234")
            {
                if (_secretDocument == null)
                {
                    _secretDocument = new SecretDocument();
                }
                _secretDocument.Display();
            }
            else
            {
                Console.WriteLine("Access denied: Incorrect password.");
            }
        }
    }
}
