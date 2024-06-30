using Interface_Segregation_Principle.Bad_Examples.Interfaces.Example9_Vehicle_Type;

namespace Interface_Segregation_Principle.Bad_Examples.Implementations.Example9_Vehicle_Type
{
    public class Aeroplane : IVehicle
    {
        public void Fly()
        {
            Console.WriteLine("Flying the airplane.");
        }
        public void Drive()
        {
            throw new NotImplementedException("Airplanes cannot drive.");
        }

    }
}
