using Interface_Segregation_Principle.Good_Examples.Interfaces.Example8_Authentication_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.Good_Examples.Implementations.Example8_Authentication_System
{
    internal class OtpAuthenticator: IOtpAuthenticator
    {
        public void AuthenticateWithOtp(string phoneNumber, string otp)
        {
            Console.WriteLine($"Authenticating with OTP for phone: {phoneNumber}");
            // Implementation details for OTP authentication
        }
    }
}
