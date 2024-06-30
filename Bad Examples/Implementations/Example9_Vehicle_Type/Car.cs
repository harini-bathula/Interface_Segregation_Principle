using Interface_Segregation_Principle.Bad_Examples.Interfaces.Example9_Vehicle_Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.Bad_Examples.Implementations.Example9_Vehicle_Type
{
    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving the car.");
        }

        public void Fly()
        {
            throw new NotImplementedException("Cars cannot fly.");
        }
    }
}
