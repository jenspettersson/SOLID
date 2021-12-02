namespace Solid.ShoppingCart
{
    public interface IDiscountRule
    {
        decimal Discount { get; }
        bool Matches(ShoppingCart cart);
    }

    public class MinMaxItemsDiscountRule : IDiscountRule
    {
        private readonly int _min;
        private readonly int _max;
        public decimal Discount { get; }

        public MinMaxItemsDiscountRule(int min, int max, decimal discount)
        {
            _min = min;
            _max = max;
            Discount = discount;
        }
        
        public bool Matches(ShoppingCart cart)
        {
            return cart.Items.Count >= _min && cart.Items.Count < _max;
        }
    }
}