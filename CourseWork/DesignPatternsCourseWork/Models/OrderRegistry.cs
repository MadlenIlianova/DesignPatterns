using DesignPatternsCourseWork.Logger;

namespace DesignPatternsCourseWork.Models
{
    public class OrderRegistry
    {
        private List<Order> _orders = new List<Order>();
        private ILogger _logger;
        private int _nextId = 1;

        public OrderRegistry(ILogger logger)
        {
            _logger = logger;
        }

        public void Register(Order order)
        {
            order.Id = _nextId++;
            _orders.Add(order);
            _logger.LogSuccess($"[REGISTRY] Order {order.Id} has been officially recorded in the system.");
        }

        public void DisplayAll()
        {
            if (!_orders.Any())
            {
                _logger.LogError("Registry is empty. No successful orders to display.");
                return;
            }

            _logger.Log($"Registered Orders ({_orders.Count} total)");
            foreach (var order in _orders)
            {
                order.DisplayOrderDetails();
            }
        }
    }
}
