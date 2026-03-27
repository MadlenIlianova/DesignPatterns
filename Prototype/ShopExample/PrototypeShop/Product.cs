using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeShop
{
    public class Product
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public int Size { get; set; }

        public Product(string name, string color, decimal price, int size)
        {
            Name = name;
            Color = color;
            Price = price;
            Size = size;
        }

        public Product Clone()
        {
            return new Product(Name, Color, Price, Size);
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}, Color: {Color}, Price: {Price}, Size: {Size}");
        }
    }
}
