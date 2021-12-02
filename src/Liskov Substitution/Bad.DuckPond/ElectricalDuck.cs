namespace Bad.DuckPond
{
    public class ElectricalDuck : IDuck
    {
        private bool _isSwimming;
        private bool _hasBatteries;

        public bool IsSwimming => _isSwimming;

        public void Swim()
        {
            if(_hasBatteries)
                _isSwimming = true;
        }

        public void InsertBatteries()
        {
            _hasBatteries = true;
        }
    }
    
    public class MechanicalDuck : IDuck
    {
        private bool _isSwimming;
        private bool _isWoundUp;
        public bool IsSwimming => _isSwimming;

        public void Swim()
        {
            if (_isWoundUp)
                _isSwimming = true;
        }

        public void WindUp()
        {
            _isWoundUp = true;
        }
    }
}