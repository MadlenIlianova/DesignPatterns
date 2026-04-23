namespace DecoratorNotifier
{
    public class BaseDecorator : INotifier
    {
        protected INotifier _notifier;

        public BaseDecorator(INotifier notifier)
        {
            _notifier = notifier;
        }

        public virtual void Send(string message)
        {
            _notifier.Send(message);
        }    
    }
}
