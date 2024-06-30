using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.Bad_Examples.Interfaces.Example1_Messaging_System
{
    public interface IMessageService
    {
        void SendEmail(string to, string subject, string body);
        void SendSMS(string to, string message);
    }
}
