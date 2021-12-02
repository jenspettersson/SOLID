namespace Solid.Radio
{
    public class Frequency
    {
        private const int MaxAllowedFrequency = 108;
        private const decimal MinAllowedFrequency = 87.5m;

        public void ChangeTo(decimal frequency)
        {
            if (frequency > MaxAllowedFrequency)
                frequency = MaxAllowedFrequency;

            if (frequency < MinAllowedFrequency)
                frequency = MinAllowedFrequency;
            
            Value = frequency;
        }

        public decimal Value { get; private set; }
    }
}