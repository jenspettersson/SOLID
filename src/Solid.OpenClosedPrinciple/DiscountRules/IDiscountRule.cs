namespace Solid.OpenClosedPrinciple.DiscountRules
{
    public interface IDiscountRule
    {
        decimal DiscountAmount { get; }
        bool Match(int itemCount);
    }
}