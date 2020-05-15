namespace Patterns_PW7
{
    internal class FedEx : IShippingStrategy
    {
        public double Calculate(Order order)
        {
            return 5;
        }
    }
}
