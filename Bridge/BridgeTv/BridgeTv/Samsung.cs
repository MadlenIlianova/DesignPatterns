namespace BridgeTv
{
    public class Samsung : IDevice
    {
        private bool isOn = false;
        private int _volume = 10;

        public void SetVolume(int volume)
        {
            _volume = volume;
            Console.WriteLine($"Samsung: сила на звука = {volume}");
        }

        public void TurnOff()
        {
            isOn = false;
            Console.WriteLine($"Samsung: изключен");
        }

        public void TurnOn()
        {
            isOn = true;
            Console.WriteLine($"Samsung: включен");
        }
    }
}
