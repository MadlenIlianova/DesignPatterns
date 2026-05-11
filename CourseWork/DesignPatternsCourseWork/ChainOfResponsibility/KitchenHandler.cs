using DesignPatternsCourseWork.Logger;
using DesignPatternsCourseWork.Models;

namespace DesignPatternsCourseWork.ChainOfResponsibility
{
    public class KitchenHandler : BaseOrderHandler
    {
        public KitchenHandler(ILogger logger) : base(logger)
        {
        }

        protected override bool CanHandle(Order order)
        {
            return order.MainDish != null ||
                   order.Dessert != null ||
                   order.Drink != null;
        }

        protected override void Process(Order order)
        {
            _logger.Log($"The order has been placed in the kitchen...");
        }
    }
}
