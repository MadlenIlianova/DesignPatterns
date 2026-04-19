namespace BridgeTv
{
    public class Remote
    {
        protected IDevice _device;
        private bool _isOn = false;

        public Remote(IDevice device)
        {
            _device = device;
        }

        public void Power()
        {
            if (_isOn)
            {
                _device.TurnOff();
                _isOn = false;
            }
            else
            {
                _device.TurnOn();
                _isOn = true;
            }
        }

        public void VolumeUp()
        {
            _device.SetVolume(20);
        }

        public void VolumeDown()
        {
            _device.SetVolume(5);
        }
    }
}
