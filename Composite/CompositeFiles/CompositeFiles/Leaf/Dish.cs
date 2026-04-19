using CompositeFiles.Component;

namespace CompositeFiles.Leaf
{
    public class Dish : MenuComponent
    {
        private double Price;

        public Dish(string name, double price) : base(name)
        {
            this.Price = price;
        }

        public override void Show()
        {
            Console.WriteLine($"{Name} - {Price} € euro.");
        }
    }
}
