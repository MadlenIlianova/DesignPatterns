public class SilverHandler extends BaseDiscountHandler{
    @Override
    public void getDiscount(String clientType) {
        if ("silver".equalsIgnoreCase(clientType)) {
            System.out.println("Silver client gets 10% discount.");
        } else {
            next(clientType);
        }
    }
}
