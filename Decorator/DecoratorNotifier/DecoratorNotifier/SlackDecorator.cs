using System;
using System.Collections.Generic;
namespace DecoratorNotifier
{
    public class SlackDecorator : BaseDecorator
    {
        private string _channel;

        public SlackDecorator(INotifier notifier, string channel) : base(notifier)
        {
            _channel = channel;
        }

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"Slack to {_channel}: {message}");
        }
    }
}
