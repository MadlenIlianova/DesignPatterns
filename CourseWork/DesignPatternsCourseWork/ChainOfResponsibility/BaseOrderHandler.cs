using DesignPatternsCourseWork.Logger;
using DesignPatternsCourseWork.Models;

namespace DesignPatternsCourseWork.ChainOfResponsibility
{
    public abstract class BaseOrderHandler : IOrderHandler
    {
        private IOrderHandler _nextHandler;
        protected ILogger _logger;

        public BaseOrderHandler(ILogger logger)
        {
            _logger = logger;
        }

        public void SetNext(IOrderHandler orderHandeler)
        {
            _nextHandler = orderHandeler;
        }

        public void Handle(Order order)
        {

            if (CanHandle(order))
            {
                Process(order);

                if (_nextHandler != null)
                    _nextHandler.Handle(order); 
            }
            else
            {
                _logger.LogError($"No handler found for order ID: {order.Id}");
            }
        }
        protected abstract bool CanHandle(Order order);
        protected abstract void Process(Order order);
    }
}
