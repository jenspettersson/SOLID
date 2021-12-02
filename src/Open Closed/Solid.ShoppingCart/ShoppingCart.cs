using System.Collections.Generic;
using System.Linq;

namespace Solid.ShoppingCart
{
    public class ShoppingCart
    {
        private readonly List<CartItem> _items;
        public ICollection<CartItem> Items => _items.ToList();

        public ShoppingCart(List<CartItem> items)
        {
            _items = items;
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