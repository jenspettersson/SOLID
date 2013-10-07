namespace Solid.Radio
{
    public class Radio
    {
        private readonly FrequencyManager _frequencyManager;
        private readonly VolumeManager _volumeManager;

        public Radio()
        {
            _frequencyManager = new FrequencyManager();
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

        public void ChangeFrequency(decimal frequency)
        {
            _frequencyManager.ChangeFrequencyTo(frequency);
        }
    }
}