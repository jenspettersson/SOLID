namespace Solid.Radio.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class VolumeManagerTests
    {
        private VolumeManager _volumeManager;

        [SetUp]
        public void SetUp()
        {
            _volumeManager = new VolumeManager();
        }

        [Test]
        public void Default_volume_should_be_set_to_5()
        {
            Assert.AreEqual(5, _volumeManager.Volume);
        }

        [Test]
        public void VolumeUp_should_raise_volume_one_level()
        {
            _volumeManager.VolumeUp();
            Assert.AreEqual(6, _volumeManager.Volume);
        }

        [Test]
        public void VolumeDome_should_lower_volume_one_level()
        {
            _volumeManager.VolumeDown();
            Assert.AreEqual(4, _volumeManager.Volume);
        }

        [Test]
        public void Should_not_be_able_to_raise_volume_over_max_allowed_volume()
        {
            _volumeManager.VolumeUp();
            _volumeManager.VolumeUp();
            _volumeManager.VolumeUp();
            _volumeManager.VolumeUp();
            _volumeManager.VolumeUp();
            _volumeManager.VolumeUp();

            Assert.AreEqual(10, _volumeManager.Volume);
        }

        [Test]
        public void Should_not_be_able_to_lower_volume_lower_than_zero()
        {
            _volumeManager.VolumeDown();
            _volumeManager.VolumeDown();
            _volumeManager.VolumeDown();
            _volumeManager.VolumeDown();
            _volumeManager.VolumeDown();
            _volumeManager.VolumeDown();

            Assert.AreEqual(0, _volumeManager.Volume);
        }
    }
}