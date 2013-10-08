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

        public decimal GetDiscountPercentage()
        {
            decimal ammount = 0;

            if (_items.Count >= 5 && _items.Count < 10)
            {
                ammount = 10;
            }
            else if (_items.Count >= 10 && _items.Count < 15)
            {
                ammount = 15;
            }
            else if (_items.Count >= 15)
            {
                ammount = 25;
            }

            return ammount;
        }

        public void Add(CartItem cartItem)
        {
            _items.Add(cartItem);
        }

        public void Remove(CartItem cartItem)
        {
            _items.Remove(cartItem);
        }
    }
}