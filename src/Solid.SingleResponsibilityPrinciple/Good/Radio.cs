using Solid.SingleResponsibilityPrinciple.Bad;

namespace Solid.SingleResponsibilityPrinciple.Good
{
    public class Radio
    {
        private readonly StationManager _stationManager;
        private readonly VolumeManager _volumeManager;

        public Radio()
        {
            _stationManager = new StationManager();
            _volumeManager = new VolumeManager();
        }
        
        public void VolumeUp()
        {
            _volumeManager.VolumeUp();
        }

        public void VolumeDown()
        {
            _volumeManager.VolumeDown();
        }

        public void Change(double frequency)
        {
            _stationManager.Change(frequency);
        }
    }
}