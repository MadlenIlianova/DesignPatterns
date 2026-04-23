namespace DecoratorCoffee
{
    public class VanillaDecorator : BaseDecorator
    {
        public VanillaDecorator(ICoffee coffee) : base(coffee)
        {
        }

        public override double GetCost() => base.GetCost() + 0.75;
        public override string GetDescription() => base.GetDescription() + ", vanilla";
    }
}
