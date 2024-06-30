using Interface_Segregation_Principle.Good_Examples.Implementations.Example7_Restaurant_Management_System;
namespace Interface_Segregation_Principle.Good_Examples.Implementations.Example7_Restaurant_Management_System
{
    internal class PaymentManager : IPaymentManager
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing payment of ${amount}");
        }

    }
}
