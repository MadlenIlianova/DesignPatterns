namespace Builder
{
    public class Program
    {
        static void Main(string[] args)
        {
           ICarBuilder builder = new CarBuilder();
            Car car = builder
                .SetName("Mustang")
                .SetModel("GT")
                .SetEngine("V8")
                .SetSeats(4)
                .SetWheels(4)
                .SetColor("Red")
                .SetYear(2022)
                .Build();

            Console.WriteLine("Car Details: ");
            Console.WriteLine();
            Console.WriteLine($"Name: {car.Name}");
            Console.WriteLine($"Model: {car.Model}");
            Console.WriteLine($"Engine: {car.Engine}");
            Console.WriteLine($"Seats: {car.Seats}");
            Console.WriteLine($"Wheels: {car.Wheels}");
            Console.WriteLine($"Color: {car.Color}");
            Console.WriteLine($"Year: {car.Year}");

        }
    }
}
