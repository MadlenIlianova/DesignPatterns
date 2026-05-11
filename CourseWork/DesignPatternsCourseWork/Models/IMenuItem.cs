namespace DesignPatternsCourseWork.Models
{
    public interface IMenuItem
    {
        string GetName { get; }
        double GetPrice { get; }
        bool IsVegetarian { get; }
        bool IsAlcoholic { get; } 
    }
}
