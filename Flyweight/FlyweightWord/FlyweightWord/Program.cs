namespace FlyweightWord
{
    public class Program
    {
        static void Main(string[] args)
        {
            var styleFactory = new StyleFactory();
            var characters = new List<Character>();

            var normal = styleFactory.GetCharacterStyle("Arial", 12, "Red");
            var heading = styleFactory.GetCharacterStyle("Arial", 24, "Blue");
            var bold = styleFactory.GetCharacterStyle("Arial Bold", 12, "Green");
            var red = styleFactory.GetCharacterStyle("Arial", 12, "Yellow");

            string text = "Hello World!";
            var random = new Random();
            CharacterStyle[] styles = { normal, heading, bold, red };

            for (int i = 0; i < 10000; i++) 
            {
                char symbol = text[i % text.Length];
                CharacterStyle style = styles[random.Next(0, 4)];
                characters.Add(new Character(symbol, i, style));
            }

            Console.WriteLine("The first 5:");
            for (int i = 0; i < 5; i++)
            {
                characters[i].Display();
            }

            Console.WriteLine($"All:{characters.Count}");
            Console.WriteLine($"Unique styles:{styleFactory.TotalStyles} ");
        }
    }
}
