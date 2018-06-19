namespace Solid.Radio
{
    public class Frequency
    {
        private const decimal HighestFrequencyAllowed = 108m;
        private const decimal LowestFrequencyAllowed = 87.5m;

        private decimal _currentFrequency;
        public decimal CurrentFrequency
        {
            get { return _currentFrequency; }
        }

        public void ChangeTo(decimal frequency)
        {
            _currentFrequency = CorrectFrequencyForAllowedRange(frequency);
        }

        private static decimal CorrectFrequencyForAllowedRange(decimal frequency)
        {
            if (frequency > HighestFrequencyAllowed)
            {
                frequency = HighestFrequencyAllowed;
            }
            else if (frequency < LowestFrequencyAllowed)
            {
                frequency = LowestFrequencyAllowed;
            }

            return frequency;
        }
    }
}