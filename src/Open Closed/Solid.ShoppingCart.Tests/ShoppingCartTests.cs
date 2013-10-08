namespace Solid.ShoppingCart.Tests
{
    using Calculation;
    using NUnit.Framework;

    [TestFixture]
    public class ShoppingCartTests
    {
        private ShoppingCart _shoppingCart;

        [SetUp]
        public void SetUp()
        {
            _shoppingCart = new ShoppingCart(new DummyDiscountCalculator());
        }

        [Test]
        public void AddItem_should_add_item_to_shopping_cart()
        {
            _shoppingCart.AddItem(new CartItem());

            Assert.IsNotEmpty(_shoppingCart.CartItems);
        }

        [Test]
        public void RemoveItem_should_remove_item_from_shopping_cart()
        {
            var cartItem = new CartItem();
            _shoppingCart.AddItem(cartItem);
            _shoppingCart.RemoveItem(cartItem);

            Assert.IsEmpty(_shoppingCart.CartItems);
        }


        private class DummyDiscountCalculator : IDiscountCalculator
        {
            public decimal Calculate(int itemCount)
            {
                return 100;
            }
        }
    }
}