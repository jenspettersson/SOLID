namespace Solid.Radio
{
    public class Radio
    {
        private Frequency _frequency;
        private Volume _volume;

        public int CurrentVolume => _volume.Value;
        public decimal CurrentFrequency => _frequency.Value;
        
        public Radio()
        {
            _frequency = new Frequency();
            _volume = new Volume();
        }
        
        public void VolumeUp()
        {
            _volume.Up();
        }

        public void VolumeDown()
        {
            _volume.Down();
        }

        public void ChangeFrequency(decimal frequency)
        {
            _frequency.ChangeTo(frequency);
        }
    }
}