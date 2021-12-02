namespace Solid.ShoppingCart
{
    public class Checkout
    {
        private readonly DiscountCalcualtor _discountCalcualtor;

        public Checkout(DiscountCalcualtor discountCalcualtor)
        {
            _discountCalcualtor = discountCalcualtor;
        }

        public decimal GetDiscountPercentage(ShoppingCart cart)
        {
            return _discountCalcualtor.GetDiscountPercentage(cart);
        }
    }
}