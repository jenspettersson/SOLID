using System.Collections.Generic;

namespace Solid.ShoppingCart
{
    public class ShoppingCart
    {
        private readonly List<CartItem> _cartItems;
        public IEnumerable<CartItem> CartItems { get { return _cartItems; } } 
        
        public ShoppingCart()
        {
            _cartItems = new List<CartItem>();
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