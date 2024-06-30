using Interface_Segregation_Principle.Bad_Examples.Interfaces.Example7_Restaurant_Management_System;

namespace Interface_Segregation_Principle.Bad_Examples.Implementations.Example7_Restaurant_Management_System
{
    internal class OrderManager : IRestaurantService
    {
        public void PlaceOrder(string orderDetails)
        {
            Console.WriteLine($"Placing order: {orderDetails}");
        }

        public void CancelReservation(int reservationId)
        {
            throw new NotImplementedException();
        }

        public void MakeReservation()
        {
            throw new NotImplementedException();
        }

        public void ProcessPayment(decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
