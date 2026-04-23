namespace DecoratorNotifier
{
    public class SmsDecorator : BaseDecorator
    {
        private string _phoneNumber;

        public SmsDecorator(INotifier notifier, string phoneNumber) : base(notifier)
        {
            _phoneNumber = phoneNumber;
        }

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"SMS to {_phoneNumber}: {message}");
        }
    }
}
