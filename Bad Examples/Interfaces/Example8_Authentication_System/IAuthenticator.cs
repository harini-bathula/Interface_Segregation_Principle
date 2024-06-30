using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.Bad_Examples.Interfaces.Example7_Restaurant_Management_System.Example8_Authentication_System
{
    public interface IAuthenticator
    {
        void AuthenticateWithEmail(string email, string password);
        void AuthenticateWithOtp(string phoneNumber, string otp);
    }
}
