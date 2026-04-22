import java.util.HashMap;
import java.util.Map;

public class SoldierFactory {
    private final Map<String, SoldierType> types = new HashMap<>();

    public SoldierType getSoldierType(String type, String color, String animation) {
        String key = type + "_" + color;

        if (!types.containsKey(key)) {
            types.put(key, new SoldierType(type, color, animation));
        }
        return types.get(key);
    }

    public int getTotalTypes() {
        return types.size();
    }
}
