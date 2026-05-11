using DesignPatternsCourseWork.Logger;
using DesignPatternsCourseWork.Models;

namespace DesignPatternsCourseWork.Builder
{
    public class KidsOrderBuilder : OrderBuilder
    {
        public KidsOrderBuilder(ILogger logger) : base(logger) { }

        public override IOrderBuilder SetMainDish(IMenuItem dish)
        {
            if (dish.GetPrice > 10.0)
            {
                _logger.LogError($"{dish.GetName} is too expensive for kids!");
                return this;
            }
            _order.MainDish = dish; 
            _logger.Log($"Added dish: {dish.GetName}");
            return this;
        }

        public override IOrderBuilder SetDrink(IMenuItem drink)
        {
            _order.Drink = drink; 
            _logger.Log($"Added drink: {drink.GetName}");
            return this;
        }

        public override IOrderBuilder SetDessert(IMenuItem dessert)
        {
            _order.Dessert = dessert; 
            _logger.Log($"Added dessert: {dessert.GetName}");
            return this;
        }
    }
}