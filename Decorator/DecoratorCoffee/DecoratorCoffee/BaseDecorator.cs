namespace DecoratorCoffee
{
    public class BaseDecorator : ICoffee
    {
        protected ICoffee _coffee;

        public BaseDecorator(ICoffee coffee)
        {
            _coffee = coffee;
        }

        public virtual double GetCost() => _coffee.GetCost();
        public virtual string GetDescription() => _coffee.GetDescription();
    }
}
