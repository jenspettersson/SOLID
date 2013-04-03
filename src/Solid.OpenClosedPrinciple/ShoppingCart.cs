using System.Collections.Generic;

namespace Solid.OpenClosedPrinciple
{
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

        public void Add(CartItem product)
        {
            // Add an item
        }

        public void Delete(CartItem product)
        {
            // Delete an item
        }
    }
}