using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.Good_Examples.Interfaces.Example7_Restaurant_Management_System
{
    public interface IReservationManager
    {
        void CancelReservation(int reservationId);
        void MakeReservation();
       

    }
}
