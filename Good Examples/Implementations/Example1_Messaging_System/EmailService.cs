using Interface_Segregation_Principle.Good_Examples.Interfaces.Example1_Messaging_System;

namespace Interface_Segregation_Principle.Good_Examples.Implementations.Example1_Messaging_System
{
    public class EmailService : IEmailService
    {
        public void SendEmail(string to, string subject, string body)
        {
            // Implementation for sending email
            Console.WriteLine($"Sending email to {to} with subject: {subject}");
            
        }
    }

}
