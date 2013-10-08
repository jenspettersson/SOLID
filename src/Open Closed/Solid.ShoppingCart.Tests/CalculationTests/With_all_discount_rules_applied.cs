namespace Solid.ShoppingCart.Tests.CalculationTests
{
    using System.Collections.Generic;
    using Calculation;
    using DiscountRules;
    using NUnit.Framework;

    [TestFixture]
    public class With_all_discount_rules_applied
    {
        private DiscountCalculator _discountCalculator;

        [SetUp]
        public void SetUp()
        {
            _discountCalculator = new DiscountCalculator(new List<IDiscountRule>
                {
                    new DiscountRuleFiveToTenItems(),
                    new DiscountRuleTenToFifteenItems()
                });
        }

        [Test]
        public void Five_items_should_give_ten_percent_discount()
        {
            decimal discount = _discountCalculator.Calculate(5);
            Assert.AreEqual(10m, discount);
        }

        [Test]
        public void Ten_items_should_give_fifteen_percent_discount()
        {
            decimal discount = _discountCalculator.Calculate(10);
            Assert.AreEqual(15m, discount);
        }
    }
}