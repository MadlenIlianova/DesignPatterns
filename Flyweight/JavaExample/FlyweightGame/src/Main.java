void main() {
    SoldierFactory factory = new SoldierFactory();
    List<Soldier> soldiers = new ArrayList<>();
    Random random = new Random();

    String[] types = {"Infantry", "Archer", "Cavalry"};
    String[] colors = {"Red", "Blue", "Green"};
    String[] animations = {"Walk", "Run", "Attack"};

    for (int i = 0; i < 10000; i++) {
        int index = random.nextInt(3);
        SoldierType type = factory.getSoldierType(types[index], colors[index], animations[index]);
        soldiers.add(new Soldier(type, random.nextInt(1000), random.nextInt(1000)));
    }

    System.out.println("\nThe first 5:");
    for (int i = 0; i < 5; i++) {
        soldiers.get(i).display();
    }

    System.out.println("\nAll soldiers: " + soldiers.size());
    System.out.println("Unique types created: " + factory.getTotalTypes());
}
