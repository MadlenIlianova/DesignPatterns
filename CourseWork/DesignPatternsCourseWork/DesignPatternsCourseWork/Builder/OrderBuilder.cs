using DesignPatternsCourseWork.Logger;
using DesignPatternsCourseWork.Models;

namespace DesignPatternsCourseWork.Builder
{
    public class OrderBuilder : IOrderBuilder
    {
        private Order _order;
        private ILogger _logger;
        private int _orderIdCounter = 1;

        public OrderBuilder(ILogger logger)
        {
            _logger = logger;
            Reset();
        }

        public Order GetOrder()
        {
            _order.TotalPrice = (_order.MainDish?.GetPrice ?? 0) + 
                (_order.Drink?.GetPrice ?? 0) + 
                (_order.Dessert?.GetPrice ?? 0);

            Order result = _order;
            Reset();
            return result;
        }

        public void Reset()
        {
            _order = new Order(_logger) 
            {
                Id = _orderIdCounter++ 
            };
        }

        public void SetDessert(IMenuItem dessert)
        {
            _order.Dessert = dessert;
            _logger.Log($"Main dish set to: {dessert.GetName} - {dessert.GetPrice} euro");
        }

        public void SetDrink(IMenuItem drink)
        {
            _order.Drink = drink;
            _logger.Log($"Main dish set to: {drink.GetName} - {drink.GetPrice} euro");
        }

        public void SetMainDish(IMenuItem dish)
        {
            _order.MainDish = dish;
            _logger.Log($"Main dish set to: {dish.GetName}  -  {dish.GetPrice} euro");
        }
    }
}
