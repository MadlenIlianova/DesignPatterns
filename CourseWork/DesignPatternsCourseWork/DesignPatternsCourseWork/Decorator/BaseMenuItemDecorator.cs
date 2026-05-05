using DesignPatternsCourseWork.Models;

namespace DesignPatternsCourseWork.Decorator
{
    public class BaseMenuItemDecorator : IMenuItem
    {
        protected IMenuItem _menuItem;

        public BaseMenuItemDecorator(IMenuItem menuItem)
        {
            _menuItem = menuItem;
        }

        public virtual string GetName => _menuItem.GetName;
        public virtual double GetPrice => _menuItem.GetPrice;
    }
}
