import java.util.ArrayList;
import java.util.List;

public class Restaurant {
    private static Restaurant instance;

    private List<String> orders = new ArrayList<String>();

    private Restaurant() {
        System.out.println("Restaurant is open!");
        System.out.println();
    }

    public static Restaurant getInstance() {
        if (instance == null) {
            instance = new Restaurant();
        }
        return instance;
    }

    public void AddOrder(String waiter, String food) {
        orders.add(waiter + food);
        System.out.println(waiter + " " + "adds" + " " + food);
    }

    public void ShowOrders() {
        System.out.println();
        System.out.println("All orders:");

        for (String orders : orders) {
            System.out.println(orders);
        }
    }
}
