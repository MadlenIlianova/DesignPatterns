public interface IDiscountHandler {
    void setNext(IDiscountHandler next);
    void getDiscount(String clientType);
}
