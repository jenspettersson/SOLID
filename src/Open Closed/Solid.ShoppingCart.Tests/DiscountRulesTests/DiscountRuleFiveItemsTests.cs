namespace Solid.ShoppingCart.Tests.DiscountRulesTests
{
    using DiscountRules;
    using NUnit.Framework;

    [TestFixture]
    public class DiscountRuleFiveItemsTests
    {
        private DiscountRuleFiveItems _discountRuleFiveItems;

        [SetUp]
        public void SetUp()
        {
            _discountRuleFiveItems = new DiscountRuleFiveItems();
        }

        [Test]
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(7)]
        [TestCase(8)]
        [TestCase(9)]
        public void Rule_should_apply_for_five_to_nine_items(int items)
        {
            Assert.True(_discountRuleFiveItems.Match(items));
        }

        [Test]
        public void Rule_should_not_apply_for_less_than_five_items()
        {
            Assert.False(_discountRuleFiveItems.Match(4));
        }

        [Test]
        public void Rule_should_not_apply_for_more_than_nine_items()
        {
            Assert.False(_discountRuleFiveItems.Match(10));
        }
    }
}