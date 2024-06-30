using Interface_Segregation_Principle.Bad_Examples.Interfaces.Example7_Restaurant_Management_System.Example8_Authentication_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.Bad_Examples.Implementations.Example8_Authentication_System
{
    internal class OtpAuthenticator: IAuthenticator
    {
        public void AuthenticateWithOtp(string phoneNumber, string otp)
        {
            Console.WriteLine($"Authenticating with otp : {otp}");
        }
        public void AuthenticateWithEmail(string email, string password)
        {
            throw new NotImplementedException();

            // Implementation details for email authentication
        }

    }
}
