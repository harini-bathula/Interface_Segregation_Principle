using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.Bad_Examples.Interfaces.Example7_Restaurant_Management_System
{
    internal class ReservationManager : IRestaurantService
    {
        public void CancelReservation(int reservationId)
        {
            Console.WriteLine($"Cancelling reservation: {reservationId}");
        }

        public void MakeReservation()
        {
            Console.WriteLine($"Making reservation");
        }
        public void ProcessPayment(decimal amount)
        {
            throw new NotImplementedException();
        }
        public void PlaceOrder(string orderDetails)
        {
            throw new NotImplementedException();
        }

      

    }
}
