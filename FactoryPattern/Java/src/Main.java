import creators.AirLogistics;
import creators.RoadLogistics;
import creators.SeaLogistics;
import interfaces.ILogistics;

void main() {
    Scanner scanner = new Scanner(System.in);

    System.out.println("Изберете тип логистика:");
    System.out.println("1. Road");
    System.out.println("2. Sea");
    System.out.println("3. Air");

    String choice = scanner.nextLine();

    ILogistics logistics;

    switch (choice) {
        case "1" -> logistics = new RoadLogistics();
        case "2" -> logistics = new SeaLogistics();
        case "3" -> logistics = new AirLogistics();
        default -> {
            System.out.println("Невалиден избор!");
            return;
        }
    }
    logistics.planDelivery();
}

