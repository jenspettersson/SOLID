using FluentAssertions;
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
            _volume.Value.Should().Be(5);
        }

        [Fact]
        public void VolumeUp_should_raise_volume_one_level()
        {
            _volume.Up();
            _volume.Value.Should().Be(6);
        }

        [Fact]
        public void VolumeDown_should_lower_volume_one_level()
        {
            _volume.Down();
            _volume.Value.Should().Be(4);
        }

        [Fact]
        public void Should_not_be_able_to_raise_volume_over_max_allowed_volume()
        {
            _volume.Up();
            _volume.Up();
            _volume.Up();
            _volume.Up();
            _volume.Up();
            
            _volume.Up(); //11
            _volume.Value.Should().Be(10);
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
            
            _volume.Down(); //-1
            _volume.Value.Should().Be(0);
        }
    }
}