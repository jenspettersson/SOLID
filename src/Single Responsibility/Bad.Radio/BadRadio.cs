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

        public void ChangeStation(double frequency)
        {
            if (frequency > 108)
                frequency = 87.5;

            _currentFrequency = frequency;
        }

        public void VolumeUp()
        {
            if(_currentVolume < 10)
                _currentVolume++;
        }

        public void VolumeDown()
        {
            if(CurrentFrequency > 0)
                _currentVolume--;
        }
    }
}
