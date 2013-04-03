namespace Solid.SingleResponsibilityPrinciple.Good
{
    public class VolumeManager
    {
        private int _volume;
        public int Volume
        {
            get { return _volume; }
        }

        public void VolumeUp()
        {
            if(_volume < 10)
                _volume++;
        }

        public void VolumeDown()
        {
            if (_volume > 0)
                _volume--;
        }
    }
}