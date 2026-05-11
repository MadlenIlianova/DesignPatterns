using DesignPatternsCourseWork.Logger;
using DesignPatternsCourseWork.Models;

namespace DesignPatternsCourseWork.ChainOfResponsibility
{
    public class DeliveryHandler : BaseOrderHandler
    {
        public DeliveryHandler(ILogger logger) : base(logger)
        {
        }

        protected override bool CanHandle(Order order)
        {
          return order.City.Equals("Sofia", StringComparison.OrdinalIgnoreCase);
        }

        protected override void Process(Order order)
        {
            _logger.Log($"Order {order.Id} is out for delivery...");
            _logger.LogSuccess($"Order {order.Id} has been delivered successfully!");
            order.DisplayOrderDetails();
        }
    }
}
