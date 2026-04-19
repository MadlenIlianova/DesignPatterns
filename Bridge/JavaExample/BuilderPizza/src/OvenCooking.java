public class OvenCooking implements ICookingMethod{
    @Override
    public String cook(String pizzaName) {
        return pizzaName + " изпечена на фурна при 250°C";
    }
}
