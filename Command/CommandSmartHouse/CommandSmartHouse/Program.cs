namespace CommandSmartHouse
{
    public class Program
    {
        static void Main(string[] args)
        {
            var remote = new RemoteControl();

            var livingRoomLight = new Light("Living Room Light");
            var kitchenLight = new Light("Kitchen Light");
            var airConditioner = new AirConditioner("Air Conditioner");

            remote.PressButton(new TurnOnLightCommand(livingRoomLight));
            remote.PressButton(new TurnOnLightCommand(kitchenLight));
            remote.PressButton(new TurnOnAirConditionerCommand(airConditioner, 22));

            Console.WriteLine("Pressing Undo 3 times:");
            remote.PressUndo();
            remote.PressUndo();
            remote.PressUndo();
        }
    }
}
