namespace FacadeRestaurant
{
    public class Program
    {
        static void Main(string[] args)
        {
           var pizzaFacade = new PizzaFacade();
           pizzaFacade.OrderPizza("Margherita", "123 Main St", 9.99m);
           Console.WriteLine();
           pizzaFacade.OrderPizza("Pepperoni", "456 Elm St", 12.99m);
        }
    }
}
