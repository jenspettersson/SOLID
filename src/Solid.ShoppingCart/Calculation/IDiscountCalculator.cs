namespace Solid.ShoppingCart.Calculation
{
    public interface IDiscountCalculator
    {
        decimal Calculate(int itemCount);
    }
}