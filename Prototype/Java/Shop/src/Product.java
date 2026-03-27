import javax.lang.model.element.Name;

public class Product {
    public String name;
    public String color;
    public Double price;
    public Integer size;

    public Product(String name, String color, Double price, Integer size)
    {
        this.name = name;
        this.color = color;
        this.price = price;
        this.size = size;
    }

    public Product Clone()
    {
         return new Product(name, color, price, size);
    }

    public void printInfo()
    {
        System.out.println("Name: " + name);// + "Color: " + Color + "Size: " + Size + "Price: " + price);
        System.out.println("Color: " + color);
        System.out.println("Size: " + size);
        System.out.println("Price: " + price);

    }
}
