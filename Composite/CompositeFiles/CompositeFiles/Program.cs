using CompositeFiles.Composite;
using CompositeFiles.Leaf;

namespace CompositeFiles
{
    public class Program
    {
        static void Main(string[] args)
        {
            Menu mainMenu = new Menu("Основно меню");

            Menu desserts = new Menu("\nДесерти");
            desserts.Add(new Dish("Торта", 5.50));
            desserts.Add(new Dish("Сладолед", 3.20));

            Menu drinks = new Menu("\nНапитки");
            drinks.Add(new Dish("Кафе", 2.00));
            drinks.Add(new Dish("Чай", 1.80));

            mainMenu.Add(new Dish("Пица", 8.50));
            mainMenu.Add(new Dish("Паста", 7.20));
            mainMenu.Add(desserts);
            mainMenu.Add(drinks);

            mainMenu.Show();
        }
    }
}
