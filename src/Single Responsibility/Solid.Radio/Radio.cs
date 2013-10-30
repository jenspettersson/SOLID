namespace Solid.Radio
{
    public class Radio
    {
        private readonly Frequency _frequency;
        private readonly Volume _volume;

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