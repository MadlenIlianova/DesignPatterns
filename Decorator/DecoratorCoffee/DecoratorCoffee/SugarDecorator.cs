namespace DecoratorCoffee
{
    public class SugarDecorator : BaseDecorator
    {
        public SugarDecorator(ICoffee coffee) : base(coffee)
        {
        }

        public override double GetCost() => base.GetCost() + 0.25;
        public override string GetDescription() => base.GetDescription() + ", sugar";    
    }
}
