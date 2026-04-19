public class Margherita extends Pizza{
    public Margherita(ICookingMethod cookingMethod) {
        super(cookingMethod);
    }

    @Override
    public String prepare() {
        return cookingMethod.cook("Маргарита");
    }
}
