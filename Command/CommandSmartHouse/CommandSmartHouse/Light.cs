namespace CommandSmartHouse
{
    public class Light //Receiver
    {
        private string _name;

        public Light(string name)
        {
            _name = name;
        }

        public void On() => Console.WriteLine($"{_name} is on");
        public void Off() => Console.WriteLine($"{_name} is off");
    }
}
