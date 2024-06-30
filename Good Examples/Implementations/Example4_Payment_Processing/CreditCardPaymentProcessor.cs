using Interface_Segregation_Principle.Good_Examples.Interfaces.Example4_Payment_Processing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.Good_Examples.Implementations.Example4_Payment_Processing
{
    public class CreditCardPaymentProcessor : ICreditCardPaymentProcessor
    {
        public void ProcessCreditCardPayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of ${amount}");
            // Implementation details for processing credit card payment
        }
    }
}
