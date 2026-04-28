public class GoldHandler extends BaseDiscountHandler{
    @Override
    public void getDiscount(String clientType) {
        if ("gold".equalsIgnoreCase(clientType)) {
            System.out.println("Gold client gets 20% discount.");
        } else {
            next(clientType);
        }
    }
}
