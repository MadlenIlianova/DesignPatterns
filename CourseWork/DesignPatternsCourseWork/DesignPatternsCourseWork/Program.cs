using DesignPatternsCourseWork.ChainOfResponsibility;
using DesignPatternsCourseWork.Decorator;
using DesignPatternsCourseWork.Models;
namespace DesignPatternsCourseWork
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Logger
            var logger = new Logger.ConsoleLogger();

            //Builder
            var orderBuilder = new Builder.OrderBuilder(logger);
            var restaurantDirector = new Builder.RestaurantDirector(orderBuilder);

            //Menu items
            IMenuItem steak = new MenuItem("Steak", 25.00);
            IMenuItem pasta = new MenuItem("Pasta", 15.00);
            IMenuItem wine = new MenuItem("Wine", 10.00);
            IMenuItem water = new MenuItem("Water", 3.00);
            IMenuItem tiramisu = new MenuItem("Tiramisu", 8.00);

            //Chain
            var validation = new ValidationHandler(logger);
            var kitchen = new KitchenHandler(logger);
            var deliver = new DeliveryHandler(logger);

            validation.SetNext(kitchen);
            kitchen.SetNext(deliver);

            //Decorator
            IMenuItem basicSteak = new MenuItem("Steak", 25.00);
            IMenuItem cheeseSteak = new CheeseDecorator(steak);
            IMenuItem steakWithSauce = new SauceDecorator(steak);
            IMenuItem steakWithSauceAndCheese = new GarnishDecorator(new CheeseDecorator(steakWithSauce));

            //Orders
            restaurantDirector.BuildFullMenu(
            new MenuItem(steakWithSauce.GetName, steakWithSauce.GetPrice),
            new MenuItem(wine.GetName, wine.GetPrice),
            new MenuItem(tiramisu.GetName, tiramisu.GetPrice)
            );
            Order order1 = orderBuilder.GetOrder();
            validation.Handle(order1);

            restaurantDirector.BuildMainOnly(
            new MenuItem(pasta.GetName, pasta.GetPrice));          
            Order order2 = orderBuilder.GetOrder();
            validation.Handle(order2);

            //Console.WriteLine("\nTest null order");
            //Order nullOrder = null;
            //validation.Handle(nullOrder);

            Console.WriteLine("\nTest order with zero price");
            Order emptyOrder = new Order(logger)
            {
                Id = 99,
                MainDish = new MenuItem("Test", 0)
            };
            validation.Handle(emptyOrder);
        }
    }
}
