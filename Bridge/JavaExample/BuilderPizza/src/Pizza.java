public abstract class Pizza {
    protected ICookingMethod cookingMethod;

    public Pizza(ICookingMethod cookingMethod) {
        this.cookingMethod = cookingMethod;
    }

    public abstract String prepare();
}
