namespace Solid.Radio
{
    public class FrequencyManager
    {
        private const decimal HighestFrequencyAllowed = 108.9m;
        private const decimal LowestFrequencyAllowed = 87.0m;

        private decimal _frequency;
        public decimal Frequency
        {
            get { return _frequency; }
        }

        public void ChangeFrequencyTo(decimal frequency)
        {
            _frequency = CorrectFrequencyForAllowedRange(frequency);
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