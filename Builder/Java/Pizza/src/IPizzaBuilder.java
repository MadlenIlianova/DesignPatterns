public interface IPizzaBuilder {
    void reset();
    void setDough(String dough);
    void setSauce(String sauce);
    void setCheese(String cheese);
    void setTopping(String topping);
    void setSize(Integer size);
    Pizza getProduct();
}
