namespace Solid.ShoppingCart.Tests.DiscountRulesTests
{
    using DiscountRules;
    using NUnit.Framework;

    [TestFixture]
    public class DiscountRuleTenToFifteenItemsTests
    {
        private DiscountRuleTenToFifteenItems _discountRuleTenToFifteenItems;

        [SetUp]
        public void SetUp()
        {
            _discountRuleTenToFifteenItems = new DiscountRuleTenToFifteenItems();
        }

        [Test]
        public void The_DiscountAmount_should_be_fifteen_percent()
        {
            Assert.AreEqual(15, _discountRuleTenToFifteenItems.DiscountAmount);
        }

        [Test]
        public void Rule_should_apply_for_ten_up_to_fourteen_items([Range(10, 14)]int items)
        {
            Assert.True(_discountRuleTenToFifteenItems.Match(items));
        }

        [Test]
        public void Rule_should_not_apply_for_less_than_ten_items()
        {
            Assert.False(_discountRuleTenToFifteenItems.Match(9));
        }

        [Test]
        public void Rule_should_not_apply_for_more_than_fourteen_items()
        {
            Assert.False(_discountRuleTenToFifteenItems.Match(15));
        }
    }
}