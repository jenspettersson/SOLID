namespace Solid.ShoppingCart.DiscountRules
{
    public class DiscountRuleTenToFifteenItems : IDiscountRule
    {
        public decimal DiscountAmount
        {
            get { return 15; }
        }

        public bool Match(int itemCount)
        {
            return itemCount >= 10 && itemCount < 15;
        }
    }
}