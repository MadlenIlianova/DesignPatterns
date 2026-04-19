void main() {
    Menu mainMenu = new Menu("Основно меню");

    Menu desserts = new Menu("Десерти");
    desserts.add(new Dish("Торта", 5.50));
    desserts.add(new Dish("Сладолед", 3.20));

    Menu drinks = new Menu("Напитки");
    drinks.add(new Dish("Кафе", 2.00));
    drinks.add(new Dish("Чай", 1.80));

    mainMenu.add(new Dish("Пица", 8.50));
    mainMenu.add(new Dish("Паста", 7.20));
    mainMenu.add(desserts);
    mainMenu.add(drinks);

    mainMenu.show(0);
}
