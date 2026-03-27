import client.Client;
import factories.AndroidFactory;
import factories.AppleFactory;
void main() {
    Scanner scanner = new Scanner(System.in);
    Client client = new Client(new AppleFactory()); // начална стойност

    while (true) {
        System.out.println("Choose phone");
        System.out.println("1 - iPhone");
        System.out.println("2 - Android (Samsung)");
        System.out.println("0 - Exit");

        String choice = scanner.nextLine();

        if (choice.equals("0")) {
            System.out.println("Bye!");
            break;
        }

        switch (choice) {
            case "1" -> client.setFactory(new AppleFactory());
            case "2" -> client.setFactory(new AndroidFactory());
            default  -> {
                System.out.println("Invalid choice!\n");
                continue;
            }
        }
        client.showPhoneSetup();
    }
    scanner.close();
}

