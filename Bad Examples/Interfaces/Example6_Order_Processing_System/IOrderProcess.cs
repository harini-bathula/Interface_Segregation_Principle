using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.Bad_Examples.Interfaces.Example6_Order_Processing_System
{
    interface IOrderProcess
    {
        bool ValidateShippingAddress(string address);
        bool ValidateCardInfo(string cardInfo);
        void ProcessOrder(string order);
    }
}
