using DesignPatternsCourseWork.Logger;
using DesignPatternsCourseWork.Models;

namespace DesignPatternsCourseWork.Builder
{
    public class OrderBuilder : IOrderBuilder
    {
        protected Order _order;
        protected readonly ILogger _logger;
        private static int _orderIdCounter = 1;

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

        public IOrderBuilder Reset()
        {
            _order = new Order(_logger) 
            {
                Id = 0
            };
            return this;
        }

        public virtual IOrderBuilder SetDessert(IMenuItem dessert)
        {
            _order.Dessert = dessert;
            _logger.Log($"Added dessert: {dessert.GetName}");
            return this;
        }

        public virtual IOrderBuilder SetDrink(IMenuItem drink)
        {
            _order.Drink = drink;
            _logger.Log($"Added drink: {drink.GetName}");
            return this;
        }

        public virtual IOrderBuilder SetMainDish(IMenuItem dish)
        {
            _order.MainDish = dish;
            _logger.Log($"Added dish: {dish.GetName}");
            return this;
        }
    }
}
