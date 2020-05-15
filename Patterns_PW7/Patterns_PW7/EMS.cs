namespace Patterns_PW7
{
    internal class EMS : IShippingStrategy
    {
        public double Calculate(Order order)
        {
            return 3;
        }
    }
}
