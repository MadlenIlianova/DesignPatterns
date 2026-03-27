package interfaces;

public interface ICharger {
    String getType();
    Integer getWatts();
    void charge();
}
