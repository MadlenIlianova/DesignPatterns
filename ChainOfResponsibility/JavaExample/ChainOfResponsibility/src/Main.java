void main() {

        IDiscountHandler bronze = new BronzeHandler();
        IDiscountHandler silver = new SilverHandler();
        IDiscountHandler gold = new GoldHandler();

        bronze.setNext(silver);
        silver.setNext(gold);

        System.out.println("Checking discounts:");

        bronze.getDiscount("bronze");
        bronze.getDiscount("silver");
        bronze.getDiscount("gold");
        bronze.getDiscount("platinum");
}
