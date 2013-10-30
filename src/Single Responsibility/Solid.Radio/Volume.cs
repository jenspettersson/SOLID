namespace Solid.Radio
{
    public class Volume
    {
        private int _currentVolume;
        public int CurrentVolume
        {
            get { return _currentVolume; }
        }

        public Volume()
        {
            _currentVolume = 5;
        }

        public void Up()
        {
            if(_currentVolume < 10)
                _currentVolume++;
        }

        public void Down()
        {
            if (_currentVolume > 0)
                _currentVolume--;
        }
    }
}