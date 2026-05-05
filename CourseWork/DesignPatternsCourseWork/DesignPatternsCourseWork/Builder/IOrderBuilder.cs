using DesignPatternsCourseWork.Models;

namespace DesignPatternsCourseWork.Builder
{
    public interface IOrderBuilder
    {
        void Reset();
        void SetMainDish(IMenuItem dish);
        void SetDrink(IMenuItem drink);
        void SetDessert(IMenuItem dessert);
        Order GetOrder();
    }
}
