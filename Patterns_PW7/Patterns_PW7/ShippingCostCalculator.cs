namespace Patterns_PW7
{
    public class ShippingCostCalculator
    {
        private IShippingStrategy _shippingStrategy;

        public ShippingCostCalculator(IShippingStrategy shippingStrategy)
        {
            _shippingStrategy = shippingStrategy;
        }

        public void SetShippingStratagy(IShippingStrategy shippingStrategy)
        {
            _shippingStrategy = shippingStrategy;
        }

        public double CostCalculator(Order order)
        {
            return _shippingStrategy.Calculate(order);
        }
    }
}
