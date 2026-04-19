namespace BridgeTv
{
    public class LG : IDevice
    {
        private bool isOn = false;
        private int _volume = 10;

        public void SetVolume(int volume)
        {
            _volume = volume;
            Console.WriteLine($"LG: сила на звука = {volume}");
        }

        public void TurnOff()
        {
            isOn = false;
            Console.WriteLine($"LG: изключен");
        }

        public void TurnOn()
        {
            isOn = true;
            Console.WriteLine($"LG: включен");
        }
    }
}
