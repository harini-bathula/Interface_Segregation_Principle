using Interface_Segregation_Principle.Good_Examples.Interfaces.Example8_Authentication_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.Good_Examples.Implementations.Example8_Authentication_System
{
    internal class EmailAuthenticator: IEmailAuthenticator
    {
        public void AuthenticateWithEmail(string email, string password)
        {
            Console.WriteLine($"Authenticating with Email: {email}");
            // Implementation details for email authentication
        }
    }
}
