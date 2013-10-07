namespace Solid.ShoppingCart
{
    using System.Collections.Generic;
    using Calculation;

    public class ShoppingCart
    {
        private readonly List<CartItem> _cartItems;
        public IEnumerable<CartItem> CartItems { get { return _cartItems; } } 
        
        private readonly IDiscountCalculator _discountCalculator;

        public ShoppingCart(IDiscountCalculator discountCalculator)
        {
            _discountCalculator = discountCalculator;
            _cartItems = new List<CartItem>();
        }

        public decimal GetDiscountPercentage()
        {
            return _discountCalculator.Calculate(_cartItems.Count);
        }

        public void AddItem(CartItem product)
        {
            _cartItems.Add(product);
        }

        public void RemoveItem(CartItem product)
        {
            _cartItems.Remove(product);
        }
    }
}