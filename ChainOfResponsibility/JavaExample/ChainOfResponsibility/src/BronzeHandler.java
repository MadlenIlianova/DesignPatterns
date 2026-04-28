public class BronzeHandler extends BaseDiscountHandler{
    @Override
    public void getDiscount(String clientType) {
        if ("bronze".equalsIgnoreCase(clientType)) {
            System.out.println("Bronze client gets 5% discount.");
        } else {
            next(clientType);
        }
    }
}
