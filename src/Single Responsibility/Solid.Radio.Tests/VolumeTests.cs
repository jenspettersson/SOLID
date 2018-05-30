using Xunit;

namespace Solid.Radio.Tests
{
    public class VolumeTests
    {
        private Volume _volume;

        public VolumeTests()
        {
            _volume = new Volume();
        }

        [Fact]
        public void Default_volume_should_be_set_to_5()
        {
            Assert.Equal(5, _volume.CurrentVolume);
        }

        [Fact]
        public void VolumeUp_should_raise_volume_one_level()
        {
            _volume.Up();
            Assert.Equal(6, _volume.CurrentVolume);
        }

        [Fact]
        public void VolumeDome_should_lower_volume_one_level()
        {
            _volume.Down();
            Assert.Equal(4, _volume.CurrentVolume);
        }

        [Fact]
        public void Should_not_be_able_to_raise_volume_over_max_allowed_volume()
        {
            _volume.Up();
            _volume.Up();
            _volume.Up();
            _volume.Up();
            _volume.Up();
            _volume.Up();

            Assert.Equal(10, _volume.CurrentVolume);
        }

        [Fact]
        public void Should_not_be_able_to_lower_volume_lower_than_zero()
        {
            _volume.Down();
            _volume.Down();
            _volume.Down();
            _volume.Down();
            _volume.Down();
            _volume.Down();

            Assert.Equal(0, _volume.CurrentVolume);
        }
    }
}