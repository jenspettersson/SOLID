namespace Solid.ShoppingCart.DiscountRules
{
    public interface IDiscountRule
    {
        decimal DiscountAmount { get; }
        bool Match(int itemCount);
    }
}