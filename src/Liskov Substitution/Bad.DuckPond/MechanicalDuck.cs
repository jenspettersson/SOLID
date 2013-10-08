namespace Bad.DuckPond
{
    public class MechanicalDuck : IDuck
    {
        private bool _isWoundUp;

        public bool IsSwimming { get; private set; }
        
        public void WindUp()
        {
            _isWoundUp = true;
        }

        public void Swim()
        {
            if (!_isWoundUp)
                return;

            IsSwimming = true;

        }
    }
}