using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.Good_Examples.Interfaces.Example8_Authentication_System
{
    public interface IOtpAuthenticator
    {
        void AuthenticateWithOtp(string phoneNumber, string otp);
    }
}
