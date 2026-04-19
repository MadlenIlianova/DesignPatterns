public class GrillCooking implements ICookingMethod{
    @Override
    public String cook(String pizzaName) {
        return pizzaName + " изпечена на грил с дървени въглища";
    }
}
