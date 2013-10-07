namespace Solid.ShoppingCart.DiscountRules
{
    public class DiscountRuleFifteenItems : IDiscountRule
    {
        public decimal DiscountAmount
        {
            get { return 20; }
        }

        public bool Match(int itemCount)
        {
            return itemCount >= 15;
        }
    }
}