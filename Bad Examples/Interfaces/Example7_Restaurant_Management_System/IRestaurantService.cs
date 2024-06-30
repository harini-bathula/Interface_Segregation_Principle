namespace Interface_Segregation_Principle.Bad_Examples.Interfaces.Example7_Restaurant_Management_System
{
    public interface IRestaurantService
    {
        void PlaceOrder(string orderDetails);
        void MakeReservation();
        void CancelReservation(int reservationId);
        void ProcessPayment(decimal amount);
    }
}
