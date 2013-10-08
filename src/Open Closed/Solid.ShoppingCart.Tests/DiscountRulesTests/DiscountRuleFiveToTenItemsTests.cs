namespace Solid.ShoppingCart.Tests.DiscountRulesTests
{
    using DiscountRules;
    using NUnit.Framework;

    [TestFixture]
    public class DiscountRuleFiveToTenItemsTests
    {
        private DiscountRuleFiveToTenItems _discountRuleFiveToTenItems;

        [SetUp]
        public void SetUp()
        {
            _discountRuleFiveToTenItems = new DiscountRuleFiveToTenItems();
        }

        [Test]
        public void The_DiscountAmount_should_be_ten_percent()
        {
            Assert.AreEqual(10, _discountRuleFiveToTenItems.DiscountAmount);
        }

        [Test]
        public void Rule_should_apply_for_five_up_to_nine_items([Range(5, 9)]int items)
        {
            Assert.True(_discountRuleFiveToTenItems.Match(items));
        }

        [Test]
        public void Rule_should_not_apply_for_less_than_five_items()
        {
            Assert.False(_discountRuleFiveToTenItems.Match(4));
        }

        [Test]
        public void Rule_should_not_apply_for_more_than_nine_items()
        {
            Assert.False(_discountRuleFiveToTenItems.Match(10));
        }
    }
}