void main() {
    ICookingMethod oven = new OvenCooking();
    ICookingMethod grill = new GrillCooking();

    Pizza pizza1 = new Margherita(oven);
    Pizza pizza2 = new Margherita(grill);
    Pizza pizza3 = new Pepperoni(oven);
    Pizza pizza4 = new Pepperoni(grill);

    System.out.println(pizza1.prepare());
    System.out.println(pizza2.prepare());
    System.out.println(pizza3.prepare());
    System.out.println(pizza4.prepare());
}
