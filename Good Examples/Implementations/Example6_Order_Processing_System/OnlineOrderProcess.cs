using Interface_Segregation_Principle.Good_Examples.Interfaces.Example6_Order_Processing_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.Good_Examples.Implementations.Example6_Order_Processing_System
{
    class OnlineOrderProcess : IOrderProcess, IOnlineOrderProcess
    {
        public void ProcessOder()
        {
            // APPLICABLE
        }

        public bool ValidateCardInfo()
        {
            // APPLICABLE
            return true;
        }

        public bool ValidateShippingAddress()
        {
            // APPLICABLE
            return true;
        }
    }
}
