using System.Collections.Generic;
using System.Linq;
using Solid.ShoppingCart.DiscountRules;

namespace Solid.ShoppingCart.Calculation
{
    public class DiscountCalculator : IDiscountCalculator
    {
        private readonly IEnumerable<IDiscountRule> _discountRules;

        public DiscountCalculator(IEnumerable<IDiscountRule> discountRules)
        {
            _discountRules = discountRules;
        }

        public decimal Calculate(int itemCount)
        {
            return _discountRules
                .First(dr => dr.Match(itemCount))
                .DiscountAmount;
        }
    }
}