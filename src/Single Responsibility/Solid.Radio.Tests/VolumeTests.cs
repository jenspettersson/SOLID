namespace Solid.Radio.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class VolumeTests
    {
        private Volume _volume;

        [SetUp]
        public void SetUp()
        {
            _volume = new Volume();
        }

        [Test]
        public void Default_volume_should_be_set_to_5()
        {
            Assert.AreEqual(5, _volume.CurrentVolume);
        }

        [Test]
        public void VolumeUp_should_raise_volume_one_level()
        {
            _volume.Up();
            Assert.AreEqual(6, _volume.CurrentVolume);
        }

        [Test]
        public void VolumeDome_should_lower_volume_one_level()
        {
            _volume.Down();
            Assert.AreEqual(4, _volume.CurrentVolume);
        }

        [Test]
        public void Should_not_be_able_to_raise_volume_over_max_allowed_volume()
        {
            _volume.Up();
            _volume.Up();
            _volume.Up();
            _volume.Up();
            _volume.Up();
            _volume.Up();

            Assert.AreEqual(10, _volume.CurrentVolume);
        }

        [Test]
        public void Should_not_be_able_to_lower_volume_lower_than_zero()
        {
            _volume.Down();
            _volume.Down();
            _volume.Down();
            _volume.Down();
            _volume.Down();
            _volume.Down();

            Assert.AreEqual(0, _volume.CurrentVolume);
        }
    }
}