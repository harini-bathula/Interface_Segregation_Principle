using Interface_Segregation_Principle.Bad_Examples.Interfaces.Example6_Order_Processing_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.Bad_Examples.Implementations.Example6_Order_Processing_System
{
    class OnlineOrderProcess : IOrderProcess
    {
        public void ProcessOrder(string order)
        {
            // APPLICABLE
        }

        public bool ValidateCardInfo(string cardInfo)
        {
            // APPLICABLE
            return true;
        }

        public bool ValidateShippingAddress(string address)
        {
            // APPLICABLE
            return true;
        }
    }
}
