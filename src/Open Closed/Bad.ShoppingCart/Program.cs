namespace Bad.ShoppingCart
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var shoppingCart = new ShoppingCart();

            for (int i = 0; i < 13; i++ )
                shoppingCart.Add(new CartItem());

            Console.WriteLine("Discount is: {0}", shoppingCart.GetDiscountPercentage());

        }
    }
}
