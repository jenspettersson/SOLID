namespace Solid.ShoppingCart.Tests.DiscountRulesTests
{
    using DiscountRules;
    using NUnit.Framework;

    [TestFixture]
    public class DiscountRuleTenItemsTests
    {
        private DiscountRuleTenItems _discountRuleTenItems;

        [SetUp]
        public void SetUp()
        {
            _discountRuleTenItems = new DiscountRuleTenItems();
        }

        [Test]
        public void Rule_should_apply_for_ten_to_fourteen_items([Range(10, 14)]int items)
        {
            Assert.True(_discountRuleTenItems.Match(items));
        }

        [Test]
        public void Rule_should_not_apply_for_less_than_ten_items()
        {
            Assert.False(_discountRuleTenItems.Match(9));
        }

        [Test]
        public void Rule_should_not_apply_for_more_than_fourteen_items()
        {
            Assert.False(_discountRuleTenItems.Match(15));
        }
    }
}