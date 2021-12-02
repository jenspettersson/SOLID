namespace Bad.Radio
{
    public class BadRadio
    {
        private double _currentFrequency;
        public double CurrentFrequency
        {
            get { return _currentFrequency; }
        }

        private int _currentVolume = 5;
        public int CurrentVolume
        {
            get { return _currentVolume; }
        }

        public void VolumeUp()
        {
            if(_currentVolume < 11)
                _currentVolume++;
        }

        public void VolumeDown()
        {
            if(CurrentVolume > 0)
                _currentVolume--;
        }

        public void ChangeFrequency(double frequency)
        {
            if (frequency > 108)
                frequency = 108;

            if (frequency < 87.5)
                frequency = 87.5;

            _currentFrequency = frequency;
        }
    }
}
