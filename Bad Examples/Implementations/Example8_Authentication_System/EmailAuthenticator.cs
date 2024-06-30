using Interface_Segregation_Principle.Bad_Examples.Interfaces.Example7_Restaurant_Management_System.Example8_Authentication_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.Bad_Examples.Implementations.Example8_Authentication_System
{
    public class EmailAuthenticator : IAuthenticator
    {
        public void AuthenticateWithEmail(string email, string password)
        {
            Console.WriteLine($"Authenticating with Email: {email}");
            // Implementation details for email authentication
        }

        public void AuthenticateWithOtp(string phoneNumber, string otp)
        {
            throw new NotImplementedException();
        }
    }
}
