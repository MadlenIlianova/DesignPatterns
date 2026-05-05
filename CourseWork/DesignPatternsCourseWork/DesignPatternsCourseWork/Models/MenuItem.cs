namespace DesignPatternsCourseWork.Models
{
    public class MenuItem : IMenuItem
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public MenuItem(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public string GetName => Name;
        public double GetPrice => Price;

    }
}
