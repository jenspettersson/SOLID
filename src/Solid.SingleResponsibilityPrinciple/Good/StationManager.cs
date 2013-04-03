namespace Solid.SingleResponsibilityPrinciple.Good
{
    public class StationManager
    {
        private double _frequency;
        public double Frequency
        {
            get { return _frequency; }
        }

        public void Change(double frequency)
        {
            if (frequency > 108.9)
                frequency = 87.8;

            _frequency = frequency;
        }
    }
}