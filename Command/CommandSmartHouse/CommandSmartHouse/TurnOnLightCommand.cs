namespace CommandSmartHouse
{
    public class TurnOnLightCommand : ICommand //ConcreteCommand
    {
        private Light _light;

        public TurnOnLightCommand(Light light)
        {
            _light = light;
        }

        public void Execute() => _light.On();

        public void Undo() => _light.Off();
    }
}
