using DesignPatternsCourseWork.Logger;
using DesignPatternsCourseWork.Models;

namespace DesignPatternsCourseWork.Builder
{
    public class VegetarianOrderBuilder : OrderBuilder
    {
        public VegetarianOrderBuilder(ILogger logger) : base(logger) { }

        public override IOrderBuilder SetMainDish(IMenuItem dish)
        {
            if (!dish.IsVegetarian)
            {
                _logger.LogError($"{dish.GetName} is not vegetarian!");
                return this;
            }
            return base.SetMainDish(dish);
        }
    }
}
