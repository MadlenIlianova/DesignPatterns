namespace PrototypeShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product template = new Product("T-Shirt", "Red", 19.99m, 42);

            Product product1 = template.Clone();
            product1.Size = 44;

            Product product2 = template.Clone();
            product2.Color = "Blue";

            Product product3 = template.Clone();
            product3.Price = 24.99m;

            template.ShowInfo();
            product1.ShowInfo();
            product2.ShowInfo();
            product3.ShowInfo();
        }
    }
}
