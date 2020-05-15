namespace Patterns_PW7
{
    internal class UPS : IShippingStrategy
    {
        public double Calculate(Order order)
        {
            return 4;
        }
    }
}
