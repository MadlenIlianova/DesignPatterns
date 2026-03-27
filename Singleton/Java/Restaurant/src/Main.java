void main() {
    Waiter waiter1 = new Waiter("Pavel" + " ");
    Waiter waiter2 = new Waiter("Dmitry" + " ");
    Waiter waiter3 = new Waiter("Svetlana" + " ");

    waiter1.TakeOrder("Pizza");
    waiter2.TakeOrder("Pasta");
    waiter3.TakeOrder("Salad");
    waiter1.TakeOrder("Soup");
    waiter3.TakeOrder("Steak");

    Restaurant.getInstance().ShowOrders();
}

