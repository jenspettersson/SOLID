using System.Collections.Generic;

namespace Solid.OpenClosedPrinciple
{
    public class OcpShoppingCart
    {
        private List<CartItem> _cartItems; 

        private readonly IDiscountCalculator _discountCalculator;

        public OcpShoppingCart(IDiscountCalculator discountCalculator)
        {
            _discountCalculator = discountCalculator;
            _cartItems = new List<CartItem>();
        }

        public decimal GetDiscountPercentage()
        {
            return _discountCalculator.Calculate(_cartItems.Count);
        }

        public void Add(CartItem product)
        {
            _cartItems.Add(product);
        }

        public void Delete(CartItem product)
        {
            _cartItems.Remove(product);
        }
    }
}