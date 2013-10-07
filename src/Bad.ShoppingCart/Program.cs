namespace Bad.ShoppingCart
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var shoppingCart = new ShoppingCart();

            shoppingCart.Add(new CartItem());
            shoppingCart.Add(new CartItem());
            shoppingCart.Add(new CartItem());
            shoppingCart.Add(new CartItem());
            shoppingCart.Add(new CartItem());

            Console.WriteLine("Discount is: {0}", shoppingCart.GetDiscountPercentage());

        }
    }
}
