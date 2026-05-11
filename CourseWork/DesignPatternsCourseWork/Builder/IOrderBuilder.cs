using DesignPatternsCourseWork.Models;

namespace DesignPatternsCourseWork.Builder
{
    public interface IOrderBuilder
    {
        IOrderBuilder Reset();
        IOrderBuilder SetMainDish(IMenuItem dish);
        IOrderBuilder SetDrink(IMenuItem drink);
        IOrderBuilder SetDessert(IMenuItem dessert);
        Order GetOrder();
    }
}
