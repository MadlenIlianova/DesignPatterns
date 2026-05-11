using DesignPatternsCourseWork.Models;

namespace DesignPatternsCourseWork.Builder
{
    public class RestaurantDirector
    {
        private IOrderBuilder _builder;

        public RestaurantDirector(IOrderBuilder builder)
        {
            _builder = builder;
        }

        public Order BuildHappyMeal(IMenuItem nuggets, IMenuItem juice, IMenuItem iceCream)
        {
            return _builder.Reset()
                           .SetMainDish(nuggets)
                           .SetDrink(juice)
                           .SetDessert(iceCream)
                           .GetOrder();
        }

        public Order BuildFullMenu(IMenuItem dish, IMenuItem drink, IMenuItem dessert)
        {
            return _builder.Reset()
                           .SetMainDish(dish)
                           .SetDrink(drink)
                           .SetDessert(dessert)
                           .GetOrder();
        }

        public Order BuildMainOnly(IMenuItem dish)
        {
            return _builder.Reset()
                           .SetMainDish(dish)
                           .GetOrder();
        }

        public Order BuildDessertOnly(IMenuItem dessert)
        {
            return _builder.Reset()
                           .SetDessert(dessert)
                           .GetOrder();
        }

        public Order BuildDrinkOnly(IMenuItem drink)
        {
            return _builder.Reset()
                           .SetDrink(drink)
                           .GetOrder();
        }
    }
}
