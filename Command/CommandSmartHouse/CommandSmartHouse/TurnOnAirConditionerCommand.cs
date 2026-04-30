namespace CommandSmartHouse
{
    public class TurnOnAirConditionerCommand : ICommand//ConcreteCommand
    {
        private AirConditioner _airConditioner;
        private int _temperature;

        public TurnOnAirConditionerCommand(AirConditioner airConditioner, int temperature)
        {
            _airConditioner = airConditioner;
            _temperature = temperature;
        }

        public void Execute() => _airConditioner.On();

        public void Undo() => _airConditioner.Off();
    }
}
