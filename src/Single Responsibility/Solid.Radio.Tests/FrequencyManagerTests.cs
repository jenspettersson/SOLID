namespace Solid.Radio.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class FrequencyManagerTests
    {
        private FrequencyManager _frequencyManager;

        [SetUp]
        public void SetUp()
        {
            _frequencyManager = new FrequencyManager();
        }

        [Test]
        public void ChangeFrequencyTo_should_change_frequency_to_value_within_available_range()
        {
            _frequencyManager.ChangeFrequencyTo(95.8m);

            Assert.AreEqual(95.8m, _frequencyManager.Frequency);
        }

        [Test]
        public void Trying_to_set_frequency_higher_than_allowed_range_should_set_it_to_highest_frequency_allowed()
        {
            _frequencyManager.ChangeFrequencyTo(999m);

            Assert.AreEqual(108.9m, _frequencyManager.Frequency);
        }

        [Test]
        public void Trying_to_set_frequency_lower_than_allowed_range_should_set_it_to_lowest_frequency_allowed()
        {
            _frequencyManager.ChangeFrequencyTo(5m);

            Assert.AreEqual(87.0m, _frequencyManager.Frequency);
        }
    }
}
