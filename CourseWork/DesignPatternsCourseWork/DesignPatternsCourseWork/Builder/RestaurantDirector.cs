using DesignPatternsCourseWork.Models;

namespace DesignPatternsCourseWork.Builder
{
    public class RestaurantDirector
    {
        private IOrderBuilder _orderBuilder;

        public RestaurantDirector(IOrderBuilder orderBuilder)
        {
            _orderBuilder = orderBuilder;
        }

        public void BuildFullMenu(IMenuItem dish, IMenuItem drink, IMenuItem dessert) 
        {
            _orderBuilder.SetMainDish(dish);
            _orderBuilder.SetDrink(drink);
            _orderBuilder.SetDessert(dessert);
        }

        public void BuildMainOnly(IMenuItem dish)
        {
            _orderBuilder.SetMainDish(dish);
        }

        public void BuildDessertOnly(IMenuItem dessert)
        {
            _orderBuilder.SetDessert(dessert);
        }

        public void BuildDrinkOnly(IMenuItem drink)
        {
            _orderBuilder.SetDrink(drink);
        }
    }
}
