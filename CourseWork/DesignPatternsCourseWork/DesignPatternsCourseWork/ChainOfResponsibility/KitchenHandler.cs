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
            return true;
        }
    

        protected override void Process(Order order)
        {
            _logger.Log($"Kitchen preparing order {order.Id}...");
        }
    }
}
