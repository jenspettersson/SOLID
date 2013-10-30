namespace Solid.Radio.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class FrequencyTests
    {
        private Frequency _frequency;

        [SetUp]
        public void SetUp()
        {
            _frequency = new Frequency();
        }

        [Test]
        public void ChangeFrequencyTo_should_change_frequency_to_value_within_available_range()
        {
            _frequency.ChangeTo(95.8m);

            Assert.AreEqual(95.8m, _frequency.CurrentFrequency);
        }

        [Test]
        public void Trying_to_set_frequency_higher_than_allowed_range_should_set_it_to_highest_frequency_allowed()
        {
            _frequency.ChangeTo(999m);

            Assert.AreEqual(108.9m, _frequency.CurrentFrequency);
        }

        [Test]
        public void Trying_to_set_frequency_lower_than_allowed_range_should_set_it_to_lowest_frequency_allowed()
        {
            _frequency.ChangeTo(5m);

            Assert.AreEqual(87.0m, _frequency.CurrentFrequency);
        }
    }
}
