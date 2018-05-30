using Xunit;

namespace Solid.ShoppingCart.Tests
{
    public class ShoppingCartTests
    {
        private ShoppingCart _shoppingCart;

        public ShoppingCartTests()
        {
            _shoppingCart = new ShoppingCart();
        }

        [Fact]
        public void AddItem_should_add_item_to_shopping_cart()
        {
            _shoppingCart.AddItem(new CartItem());

            Assert.NotEmpty(_shoppingCart.CartItems);
        }

        [Fact]
        public void RemoveItem_should_remove_item_from_shopping_cart()
        {
            var cartItem = new CartItem();
            _shoppingCart.AddItem(cartItem);
            _shoppingCart.RemoveItem(cartItem);

            Assert.Empty(_shoppingCart.CartItems);
        }
    }
}