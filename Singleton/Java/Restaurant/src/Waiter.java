public class Waiter {
private String name;

public Waiter(String name)
{
    this.name = name;
}

    public void TakeOrder(String food)
    {
        Restaurant.getInstance().AddOrder(name, food);
    }
}
