using DesignPatternsCourseWork.Logger;

namespace DesignPatternsCourseWork.Models
{
    public class Order
    {
        private ILogger _logger;
        public int Id { get; set; }
        public IMenuItem MainDish { get; set; }
        public IMenuItem Drink { get; set; }
        public IMenuItem Dessert { get; set; }
        public double TotalPrice { get; set; }

        public Order(ILogger logger)
        {
            _logger = logger;
        }

        public void DisplayOrderDetails()
        {
            _logger.Log($"Order ID: {Id}");
            _logger.Log($"Main Dish: {MainDish?.GetName}");
            _logger.Log($"Drink: {Drink?.GetName}");
            _logger.Log($"Dessert: {Dessert?.GetName}");
            _logger.LogSuccess($"Total Price: ${TotalPrice}");
        }
    }
}
