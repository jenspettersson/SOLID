using System.Collections.Generic;

namespace Solid.ShoppingCart
{
   public class TwentyOrMoreItemsDiscountRule : IDiscountRule
    {
        public decimal Discount => 0.25m;

        public bool Matches(ShoppingCart cart)
        {
            return cart.Items.Count >= 20;
        }
    }
   
    public class DiscountCalcualtor
    {
        private readonly List<IDiscountRule> _discountRules;

        public DiscountCalcualtor(List<IDiscountRule> discountRules)
        {
            _discountRules = discountRules;
        }
        
        public decimal GetDiscountPercentage(ShoppingCart cart)
        {
            decimal amount = 0;

            foreach (var discountRule in _discountRules)
            {
                if (discountRule.Matches(cart))
                {
                    amount = discountRule.Discount;
                    break;
                }
            }

            return amount;
        }
    }
}