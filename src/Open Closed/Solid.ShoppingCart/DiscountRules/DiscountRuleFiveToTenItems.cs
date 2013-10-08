namespace Solid.ShoppingCart.DiscountRules
{
    public class DiscountRuleFiveToTenItems : IDiscountRule
    {
        public decimal DiscountAmount
        {
            get { return 10; }
        }

        public bool Match(int itemCount)
        {
            return itemCount >= 5 && itemCount < 10;
        }
    }
}