using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Solid.ShoppingCart.Tests
{
    public class CheckoutTests
    {
        private Checkout _checkout;

        public CheckoutTests()
        {
            var standardDiscountCalculator = new DiscountCalcualtor(new List<IDiscountRule>
            {
                new MinMaxItemsDiscountRule(5, 10, 0.1m),
                new MinMaxItemsDiscountRule(10, 15, 0.15m),
                new MinMaxItemsDiscountRule(15, 20, 0.2m),
                new TwentyOrMoreItemsDiscountRule()
            });

            _checkout = new Checkout(standardDiscountCalculator);
        }

        [Fact]
        public void Five_items_should_give_10_percentage_discount()
        {
            var discountPercentage = _checkout.GetDiscountPercentage(new ShoppingCart(new List<CartItem>
            {
                new CartItem(),
                new CartItem(),
                new CartItem(),
                new CartItem(),
                new CartItem()
            }));

            discountPercentage.Should().Be(0.1m);
        }
        
        [Fact]
        public void Ten_items_should_give_15_percentage_discount()
        {
            var discountPercentage = _checkout.GetDiscountPercentage(new ShoppingCart(new List<CartItem>
            {
                new CartItem(),
                new CartItem(),
                new CartItem(),
                new CartItem(),
                new CartItem(),
                
                new CartItem(),
                new CartItem(),
                new CartItem(),
                new CartItem(),
                new CartItem(),
            }));

            discountPercentage.Should().Be(0.15m);
        }
        
        [Fact]
        public void Fifteen_items_should_give_20_percentage_discount()
        {
            var discountPercentage = _checkout.GetDiscountPercentage(new ShoppingCart(new List<CartItem>
            {
                new CartItem(),
                new CartItem(),
                new CartItem(),
                new CartItem(),
                new CartItem(),
                
                new CartItem(),
                new CartItem(),
                new CartItem(),
                new CartItem(),
                new CartItem(),
                
                new CartItem(),
                new CartItem(),
                new CartItem(),
                new CartItem(),
                new CartItem(),
            }));

            discountPercentage.Should().Be(0.20m);
        }
        
        [Fact]
        public void Twenty_items_should_give_25_percentage_discount()
        {
            var discountPercentage = _checkout.GetDiscountPercentage(new ShoppingCart(new List<CartItem>
            {
                new CartItem(),
                new CartItem(),
                new CartItem(),
                new CartItem(),
                new CartItem(),
                
                new CartItem(),
                new CartItem(),
                new CartItem(),
                new CartItem(),
                new CartItem(),
                
                new CartItem(),
                new CartItem(),
                new CartItem(),
                new CartItem(),
                new CartItem(),
                
                new CartItem(),
                new CartItem(),
                new CartItem(),
                new CartItem(),
                new CartItem()
            }));

            discountPercentage.Should().Be(0.25m);
        }
        
    }
}