namespace AdapterPizza
{
    public class Program
    {
        static void Main(string[] args)
        {
           var pizzaAdapter = new PizzaAdapter();
           var pizzaShop = new PizzaShop(pizzaAdapter);

           pizzaShop.Order("Margherita");
           pizzaShop.Order("Pepperoni");
           pizzaShop.Order("Hawaiian");
        }
    }
}
