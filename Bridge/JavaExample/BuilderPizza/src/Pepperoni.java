public class Pepperoni extends Pizza{
    public Pepperoni(ICookingMethod cookingMethod) {
        super(cookingMethod);
    }

    @Override
    public String prepare() {
        return cookingMethod.cook("Пеперони");
    }
}
