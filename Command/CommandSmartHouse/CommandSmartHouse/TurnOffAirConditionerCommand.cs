namespace CommandSmartHouse
{
    public class TurnOffAirConditionerCommand : ICommand //ConcreteCommand
    {
        private AirConditioner _airConditioner;
        private int _temperature;

        public TurnOffAirConditionerCommand(AirConditioner airConditioner, int temperature)
        {
            _airConditioner = airConditioner;
            _temperature = temperature;
        }

        public void Execute() => _airConditioner.Off();

        public void Undo() => _airConditioner.On();
    }
}
