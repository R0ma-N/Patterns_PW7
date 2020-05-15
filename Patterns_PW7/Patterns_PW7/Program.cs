using System;

namespace Patterns_PW7
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();

            ShippingCostCalculator shippingCostCalculator = new ShippingCostCalculator(new EMS());
            Console.WriteLine(shippingCostCalculator.CostCalculator(order));

            shippingCostCalculator.SetShippingStratagy(new UPS());
            Console.WriteLine(shippingCostCalculator.CostCalculator(order));

            shippingCostCalculator.SetShippingStratagy(new FedEx());
            Console.WriteLine(shippingCostCalculator.CostCalculator(order));
        }
    }
}
