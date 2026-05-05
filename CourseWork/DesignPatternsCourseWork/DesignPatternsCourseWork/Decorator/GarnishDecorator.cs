using DesignPatternsCourseWork.Models;

namespace DesignPatternsCourseWork.Decorator
{
    public class GarnishDecorator : BaseMenuItemDecorator
    {
        public GarnishDecorator(IMenuItem menuItem) : base(menuItem)
        {
        }

        public override string GetName => $"{_menuItem.GetName} with garnish";
        public override double GetPrice => _menuItem.GetPrice + 3.50;
    }
}
