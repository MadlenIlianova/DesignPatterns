import java.math.BigDecimal;

public class BillingService {
    public void processPayment(String pizzaType, BigDecimal amount) {
        System.out.println("Processing payment of " + amount + " euro for " + pizzaType);
    }
}
