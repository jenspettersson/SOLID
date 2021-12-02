namespace Bad.DuckPond
{
    public class Duck : IDuck
    {
        private bool _isSwimming;
        public bool IsSwimming => _isSwimming;
        public void Swim()
        {
            _isSwimming = true;
        }
    }
}