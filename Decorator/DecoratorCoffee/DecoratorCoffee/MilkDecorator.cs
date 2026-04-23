namespace DecoratorCoffee
{
    public class MilkDecorator : BaseDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee)
        {
        }

        public override double GetCost() => base.GetCost() + 0.50;
        public override string GetDescription() => base.GetDescription() + ", milk";
    }
}
