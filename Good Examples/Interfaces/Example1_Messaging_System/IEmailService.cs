using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.Good_Examples.Interfaces.Example1_Messaging_System
{
    public interface IEmailService
    {
        void SendEmail(string to, string subject, string body);
    }
}
