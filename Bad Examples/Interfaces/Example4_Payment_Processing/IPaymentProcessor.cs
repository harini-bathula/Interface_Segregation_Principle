using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.Bad_Examples.Interfaces.Example4_Payment_Processing
{
    public interface IPaymentProcessor
    {
        void ProcessCreditCardPayment(decimal amount);
        void ProcessPayPalPayment(decimal amount);
    }
}
