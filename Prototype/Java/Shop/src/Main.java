void main() {
    Product template = new Product("T-Shirt", "Red", 19.99, 42);

    Product product1 = template.Clone();
    product1.size = 44;

    Product product2 = template.Clone();
    product2.color = "Black";

    Product product3 = template.Clone();
    product3.price = 44.99;

    template.printInfo();
    System.out.println();
    product1.printInfo();
    System.out.println();
    product2.printInfo();
    System.out.println();
    product3.printInfo();

}
