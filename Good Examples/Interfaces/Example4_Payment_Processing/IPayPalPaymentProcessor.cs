using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.Good_Examples.Interfaces.Example4_Payment_Processing
{
    public interface IPayPalPaymentProcessor
    {
        void ProcessPayPalPayment(decimal amount);
    }
}
