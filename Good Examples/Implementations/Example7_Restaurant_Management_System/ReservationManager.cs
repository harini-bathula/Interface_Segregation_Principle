namespace Interface_Segregation_Principle.Good_Examples.Interfaces.Example7_Restaurant_Management_System
{
    internal class ReservationManager : IReservationManager
    {
        public void CancelReservation(int reservationId)
        {
            Console.WriteLine($"Cancelling reservation: {reservationId}");
        }

        public void MakeReservation()
        {
            Console.WriteLine($"Making reservation");
        }

    }
}
