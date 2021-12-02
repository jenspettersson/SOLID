namespace Bad.ShoppingCart
{
    using System.Collections.Generic;

    public class ShoppingCart
    {
        private readonly List<CartItem> _items;

        public ShoppingCart()
        {
            _items = new List<CartItem>();
        }

        public void Add(CartItem cartItem)
        {
            _items.Add(cartItem);
        }

        public void Remove(CartItem cartItem)
        {
            _items.Remove(cartItem);
        }

        public decimal GetDiscountPercentage()
        {
            decimal amount = 0;

            if (_items.Count >= 5 && _items.Count < 10)
            {
                amount = 0.1m;
            }
            else if (_items.Count >= 10 && _items.Count < 15)
            {
                amount = 0.15m;
            }
            else if (_items.Count >= 15 && _items.Count < 20)
            {
                amount = 0.2m;
            }
            else if (_items.Count >= 20)
            {
                amount = 0.25m;
            }

            return amount;
        }
    }
}