﻿using Interface_Segregation_Principle.Good_Examples.Interfaces.Example1_Messaging_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.Good_Examples.Implementations.Example1_Messaging_System
{
    public class SMSService : ISMSService
    {
        public void SendSMS(string to, string message)
        {
            // Implementation for sending SMS
            Console.WriteLine($"Sending SMS to {to}: {message}");
        }
    }
}
