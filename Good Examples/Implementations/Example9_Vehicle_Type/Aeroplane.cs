using Interface_Segregation_Principle.Good_Examples.Interfaces.Example9_Vehicle_Type;

namespace Interface_Segregation_Principle.Good_Examples.Implementations.Example9_Vehicle_Type
{
    public class Aeroplane : IFly
    {
        public void Fly()
        {
            Console.WriteLine("Flying the airplane.");
        }
    }
}
