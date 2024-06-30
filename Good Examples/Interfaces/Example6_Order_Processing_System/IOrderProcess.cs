using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.Good_Examples.Implementations.Example6_Order_Processing_System
{
    interface IOrderProcess
    {
        bool ValidateShippingAddress();
        void ProcessOder();

    }
}
