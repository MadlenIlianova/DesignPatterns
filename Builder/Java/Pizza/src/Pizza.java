public class Pizza {
    private String dough;
    private String sauce;
    private String cheese;
    private String topping;
    private Integer size;

    public String getDough() {
        return dough;
    }

    public void setDough(String dough) {
        this.dough = dough;
    }

    public String getSauce() {
        return sauce;
    }

    public void setSauce(String sauce) {
        this.sauce = sauce;
    }

    public String getCheese() {
        return cheese;
    }

    public void setCheese(String cheese) {
        this.cheese = cheese;
    }

    public String getTopping() {
        return topping;
    }

    public void setTopping(String topping) {
        this.topping = topping;
    }

    public Integer getSize() {
        return size;
    }

    public void setSize(Integer size) {
        this.size = size;
    }

    public Pizza() {
        this.dough = dough;
        this.sauce = sauce;
        this.cheese = cheese;
        this.topping = topping;
        this.size = size;
    }

    public String listParts() {
        return String.format("Dough: %s, Sauce: %s, Cheese: %s, Topping: %s, Size: %d см",
                dough, sauce, cheese, topping, size);
    }
}
