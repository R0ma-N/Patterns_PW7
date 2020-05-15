namespace Patterns_PW7
{
    public class Order
    {
        public ShippingOptions ShippingMethod { get; set; }
        public Address Destination { get; set; }
        public Address Origin { get; set; }
    }
}
