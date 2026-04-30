namespace CommandSmartHouse
{
    public class TurnOffLightCommand : ICommand //ConcreteCommand
    {
        private Light _light;

        public TurnOffLightCommand(Light light)
        {
            _light = light;
        }

        public void Execute() => _light.Off();

        public void Undo() => _light.On();
    }
}
