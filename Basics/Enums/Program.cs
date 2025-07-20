namespace Enums
{
    enum ShippingMethod
    {
        Standard,
        Express,
        Overnight
    } // It starts enumeration from 0 by default, but we can change it to start from a different number.
    enum OrderStatus
    {
        Pending = 6,
        Processing = 2,
        Shipped = 3,
        Delivered = 4,
        Cancelled = 5
    }
    class Program
    {
        static void Main(string[] args)
        {
            ShippingMethod method = ShippingMethod.Express;
            Console.WriteLine($"Selected shipping method: {method} ({(int)method})");
            Console.WriteLine(method.ToString()); // Converts enum to string
    
            var methodId = 0;
            Console.WriteLine( (ShippingMethod)methodId ); //casts int to enum

            var order = "Pending";
            var status = (OrderStatus)Enum.Parse(typeof(OrderStatus), order);
            Console.WriteLine($"Order status: {status} ({(int)status})");




        }
    }
}
