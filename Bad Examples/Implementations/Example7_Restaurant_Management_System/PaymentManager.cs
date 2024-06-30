using Interface_Segregation_Principle.Bad_Examples.Interfaces.Example7_Restaurant_Management_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.Bad_Examples.Implementations.Example7_Restaurant_Management_System
{
    internal class PaymentManager : IRestaurantService
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing payment of ${amount}");
        }
        public void PlaceOrder(string orderDetails)
        {
            throw new NotImplementedException();
        }

        public void CancelReservation(int reservationId)
        {
            throw new NotImplementedException();
        }

        public void MakeReservation()
        {
            throw new NotImplementedException();
        }

    }
}
