using DesignPatternsCourseWork.Models;

namespace DesignPatternsCourseWork.Decorator
{
    public class SauceDecorator : BaseMenuItemDecorator
    {
        public SauceDecorator(IMenuItem menuItem) : base(menuItem)
        {        
        }

        public override string GetName => $"{_menuItem.GetName} with sauce";
        public override double GetPrice => _menuItem.GetPrice + 1.50;
    }
}
