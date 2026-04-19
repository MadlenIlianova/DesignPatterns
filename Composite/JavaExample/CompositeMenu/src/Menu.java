import java.util.ArrayList;
import java.util.List;

public class Menu extends MenuComponent{
    private List<MenuComponent> items = new ArrayList<>();

    public Menu(String name) {
        super(name);
    }

    public void add(MenuComponent component) {
        items.add(component);
    }

    @Override
    public void show(int indent) {
        String spacing = "  ".repeat(indent);
        System.out.println(spacing + "[" + name.toUpperCase() + "]");

        for (MenuComponent item : items) {
            item.show(indent + 1);
        }
    }
}
