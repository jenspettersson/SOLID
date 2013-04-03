using System.Collections.Generic;
using NUnit.Framework;
using Solid.OpenClosedPrinciple;
using Solid.OpenClosedPrinciple.DiscountRules;

namespace Solid
{
    [TestFixture]
    public class OpenClosedPrincipleRinner
    {
        public OpenClosedPrincipleRinner()
        {
            var discountRules = new List<IDiscountRule>
                {
                    new DiscountRuleFiveItems(), new DiscountRuleTenItems(), new DiscountRuleFifteenItems()
                };

            var ocpShoppingCart = new OcpShoppingCart(new DiscountCalculator(discountRules));
        }
    }
}