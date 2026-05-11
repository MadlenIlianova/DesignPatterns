namespace DesignPatternsCourseWork.Models
{
    public class MenuItem : IMenuItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsVegetarian { get; }
        public bool IsAlcoholic { get; }

        public MenuItem(string name, double price, bool isVegetarian = false, bool isAlcoholic = false)
        {
            Name = name;
            Price = price;
            IsVegetarian = isVegetarian;
            IsAlcoholic = isAlcoholic;
        }
        public string GetName => Name;
        public double GetPrice => Price;
    }
}
