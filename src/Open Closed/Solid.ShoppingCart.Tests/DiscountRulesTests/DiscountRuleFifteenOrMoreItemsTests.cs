namespace Solid.ShoppingCart.Tests.DiscountRulesTests
{
    using DiscountRules;
    using NUnit.Framework;

    [TestFixture]
    public class DiscountRuleFifteenOrMoreItemsTests
    {
        private DiscountRuleFifteenOrMoreItems _discountRuleFifteenOrMoreItems;

        [SetUp]
        public void SetUp()
        {
            _discountRuleFifteenOrMoreItems = new DiscountRuleFifteenOrMoreItems();
        }

        [Test]
        public void Rule_should_not_apply_for_less_than_fifteen_items()
        {
            Assert.False(_discountRuleFifteenOrMoreItems.Match(14));
        }

        [Test]
        public void Rule_should_apply_for_fifteen_items()
        {
            Assert.True(_discountRuleFifteenOrMoreItems.Match(15));
        }
    }
}