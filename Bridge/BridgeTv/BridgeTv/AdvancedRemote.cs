namespace BridgeTv
{
    public class AdvancedRemote : Remote
    {
        public AdvancedRemote(IDevice device) : base(device)
        {
        }

        public void Mute()
        {
            _device.SetVolume(0);
            Console.WriteLine("Заглушено!");
        }
    }
}
