namespace Solid.ShoppingCart.Tests.DiscountRulesTests
{
    using DiscountRules;
    using NUnit.Framework;

    [TestFixture]
    public class DiscountRuleFifteenItemsTests
    {
        private DiscountRuleFifteenItems _discountRuleFifteenItems;

        [SetUp]
        public void SetUp()
        {
            _discountRuleFifteenItems = new DiscountRuleFifteenItems();
        }


        [Test]
        public void Rule_should_not_apply_for_less_than_fifteen_items()
        {
            Assert.False(_discountRuleFifteenItems.Match(14));
        }

        [Test]
        public void Rule_should_apply_for_fifteen_items()
        {
            Assert.True(_discountRuleFifteenItems.Match(15));
        }
    }
}