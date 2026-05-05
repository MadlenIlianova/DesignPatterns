using DesignPatternsCourseWork.Models;

namespace DesignPatternsCourseWork.Decorator
{
    public class CheeseDecorator : BaseMenuItemDecorator
    {
        public CheeseDecorator(IMenuItem menuItem) : base(menuItem)
        {            
        }

        public override string GetName => $"{_menuItem.GetName} with cheese";
        public override double GetPrice => _menuItem.GetPrice + 2.00;
    }
}
