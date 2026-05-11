using DesignPatternsCourseWork.Builder;
using DesignPatternsCourseWork.ChainOfResponsibility;
using DesignPatternsCourseWork.Decorator;
using DesignPatternsCourseWork.Models;

namespace DesignPatternsCourseWork
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Logger/Register
            var logger = new Logger.ConsoleLogger();
            var orderRegistry = new OrderRegistry(logger);

            //Chain of Responsibility
            var validation = new ValidationHandler(logger);
            var kitchen = new KitchenHandler(logger);
            var delivery = new DeliveryHandler(logger);
            var registration = new RegistrationHandler(logger, orderRegistry);

            validation.SetNext(registration);
            registration.SetNext(kitchen);
            kitchen.SetNext(delivery);

            //Orders and Builders            
            var standardBuilder = new OrderBuilder(logger);
            var standardDirector = new RestaurantDirector(standardBuilder);

            IMenuItem steak = new MenuItem("Steak", 25.00);
            IMenuItem decoratedSteak = new SauceDecorator(new CheeseDecorator(steak));
            IMenuItem wine = new MenuItem("Wine", 10.00);
            IMenuItem tiramisu = new MenuItem("Tiramisu", 8.00);

            Console.WriteLine("\nTest 1: Standard Menu with Decorators");
            Order order1 = standardDirector.BuildFullMenu(decoratedSteak, wine, tiramisu);
            order1.City = "Sofia";
            validation.Handle(order1);


            Console.WriteLine("\nTest 2: Invalid City (Plovdiv)");
            Order order2 = standardDirector.BuildMainOnly(new MenuItem("Pasta", 15.00));
            order2.City = "Plovdiv";
            validation.Handle(order2);


            Console.WriteLine("\nTest 3: Kids Menu (Valid)");
            var kidsBuilder = new KidsOrderBuilder(logger);
            var kidsDirector = new RestaurantDirector(kidsBuilder);

            Order order3 = kidsDirector.BuildHappyMeal(
                 new MenuItem("Chicken Nuggets", 7.00),
                 new MenuItem("Apple Juice", 2.00),
                 new MenuItem("Ice Cream", 3.00));

            order3.City = "Sofia";
            validation.Handle(order3);


            Console.WriteLine("\nTest 4: Kids Menu (Error - Too Expensive)");
            Order expensiveKidsOrder = kidsDirector.BuildMainOnly(new MenuItem("Large Pizza", 15.00));
            expensiveKidsOrder.City = "Sofia";
            validation.Handle(expensiveKidsOrder);


            Console.WriteLine("\nTest 5: Vegetarian Menu (Valid)");
            var vegBuilder = new VegetarianOrderBuilder(logger);
            var vegDirector = new RestaurantDirector(vegBuilder);

            IMenuItem salad = new MenuItem("Salad", 8.00, true);
            IMenuItem water = new MenuItem("Water", 1.50, true);
            IMenuItem fruit = new MenuItem("Fruit Plate", 4.00, true);


            Order vegOrder = vegDirector.BuildFullMenu(salad, water, fruit);
            vegOrder.City = "Sofia";
            validation.Handle(vegOrder);


            Console.WriteLine("\nTest 6: Vegetarian Menu (Error - Meat)");
            Order meatVegOrder = vegDirector.BuildMainOnly(new MenuItem("Beef Burger", 12.00, false));
            meatVegOrder.City = "Sofia";
            validation.Handle(meatVegOrder);

            Console.WriteLine("\nFINAL REGISTRY REPORT:");
            orderRegistry.DisplayAll();
            Console.ReadLine();
        }
    }
}

