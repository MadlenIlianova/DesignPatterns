namespace DecoratorNotifier
{
    public class Program
    {
        static void Main(string[] args)
        {
            INotifier notifier = new EmailNotifier("madlenveselinova4@gmail.com");
            notifier.Send("Hello via Email!");
            Console.WriteLine();

            notifier = new SmsDecorator(notifier, "+1234567890");
            notifier.Send("Hello via Email and SMS!");
            Console.WriteLine();

            notifier = new SlackDecorator(notifier, "#general");
            notifier.Send("Hello via Email, SMS, and Slack!");
            Console.WriteLine();
        }
    }
}
