using DesignPatternsCourseWork.Logger;
using DesignPatternsCourseWork.Models;

namespace DesignPatternsCourseWork.ChainOfResponsibility
{
    public class ValidationHandler : BaseOrderHandler
    {
        public ValidationHandler(ILogger logger) : base(logger)
        {
        }

        protected override bool CanHandle(Order order)
        {
            if (order == null)
            {
                _logger.LogError("Order is null.");
                return false;
            }

            if (order.TotalPrice <= 0)
            {
                _logger.LogError($"Order ID: {order.Id} has invalid total price: {order.TotalPrice}");
                return false;
            }

            return true;
        }

        protected override void Process(Order order)
        {
            _logger.LogSuccess($"Order validation {order.Id} was successful!");
        }
    }
}
