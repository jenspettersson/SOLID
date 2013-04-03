using System.Collections.Generic;
using System.Linq;
using Solid.OpenClosedPrinciple.DiscountRules;

namespace Solid.OpenClosedPrinciple
{
    public class DiscountCalculator : IDiscountCalculator
    {
        private readonly List<IDiscountRule> _discountRules;

        public DiscountCalculator(List<IDiscountRule> discountRules)
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