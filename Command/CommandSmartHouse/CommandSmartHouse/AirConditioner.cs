namespace CommandSmartHouse
{
    public class AirConditioner //Receiver
    {
        private string _name;

        public AirConditioner(string name)
        {
            _name = name;
        }

        public void On() => Console.WriteLine($"{_name} is on");
        public void Off() => Console.WriteLine($"{_name} is off");
    }
}
