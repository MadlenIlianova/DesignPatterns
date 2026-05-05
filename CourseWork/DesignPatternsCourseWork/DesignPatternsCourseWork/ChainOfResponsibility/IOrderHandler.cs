using DesignPatternsCourseWork.Models;

namespace DesignPatternsCourseWork.ChainOfResponsibility
{
    public interface IOrderHandler
    {
        void SetNext(IOrderHandler orderHandeler);
        void Handle(Order order);
    }
}
