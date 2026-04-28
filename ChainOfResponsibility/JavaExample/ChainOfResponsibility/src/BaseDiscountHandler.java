public abstract class BaseDiscountHandler implements IDiscountHandler{
    private IDiscountHandler next;

    @Override
    public void setNext(IDiscountHandler next) {
        this.next = next;
    }

    protected void next(String clientType) {
        if (this.next != null) {
            this.next.getDiscount(clientType);
        } else {
            System.out.println("No discount available for this client type.");
        }
    }

    public abstract void getDiscount(String clientType);
}
