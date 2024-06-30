using Interface_Segregation_Principle.Bad_Examples.Interfaces.Example1_Messaging_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.Bad_Examples.Implementations.Example1_Messaging_System
{
    public class EmailSender: IMessageService
    {
        public void SendEmail(string to, string subject, string body)
        {
            Console.WriteLine($"Sending email to {to} with subject: {subject} body: {body}");
        }

        public void SendSMS(string to, string message)
        {
            throw new NotImplementedException();
        }

    }
}
