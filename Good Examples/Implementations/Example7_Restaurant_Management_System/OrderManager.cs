using Interface_Segregation_Principle.Good_Examples.Implementations.Example7_Restaurant_Management_System;

namespace Interface_Segregation_Principle.Good_Examples.Implementations.Example7_Restaurant_Management_System
{
    internal class OrderManager : IOrderManager
    {
        public void PlaceOrder(string orderDetails)
        {
            Console.WriteLine($"Placing order: {orderDetails}");
        }
    }
}
