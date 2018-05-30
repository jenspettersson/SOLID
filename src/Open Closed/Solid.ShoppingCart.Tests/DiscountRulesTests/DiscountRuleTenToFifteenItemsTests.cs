using System.ComponentModel.DataAnnotations;
using Solid.ShoppingCart.DiscountRules;
using Xunit;

namespace Solid.ShoppingCart.Tests.DiscountRulesTests
{
    public class DiscountRuleTenToFifteenItemsTests
    {
        private DiscountRuleTenToFifteenItems _discountRuleTenToFifteenItems;

        public DiscountRuleTenToFifteenItemsTests()
        {
            _discountRuleTenToFifteenItems = new DiscountRuleTenToFifteenItems();
        }

        [Fact]
        public void The_DiscountAmount_should_be_fifteen_percent()
        {
            Assert.Equal(15, _discountRuleTenToFifteenItems.DiscountAmount);
        }

        [Theory]
        [InlineData(10)]
        [InlineData(11)]
        [InlineData(12)]
        [InlineData(13)]
        [InlineData(14)]
        public void Rule_should_apply_for_ten_up_to_fourteen_items(int items)
        {
            Assert.True(_discountRuleTenToFifteenItems.Match(items));
        }

        [Fact]
        public void Rule_should_not_apply_for_less_than_ten_items()
        {
            Assert.False(_discountRuleTenToFifteenItems.Match(9));
        }

        [Fact]
        public void Rule_should_not_apply_for_more_than_fourteen_items()
        {
            Assert.False(_discountRuleTenToFifteenItems.Match(15));
        }
    }
}