

using Interface_Segregation_Principle.Bad_Examples.Implementations.Example9_Vehicle_Type;
using Interface_Segregation_Principle.Bad_Examples.Interfaces.Example9_Vehicle_Type;
using Interface_Segregation_Principle.Good_Examples.Interfaces.Example9_Vehicle_Type;

class Program
{
    static void Main(string[] args)
    {

        // Bad example usage (should illustrate why it's bad)
        IVehicle badCar = new Car();
        badCar.Drive();
        // badCar.Fly(); // This would throw an exception

        IVehicle badAirplane = new Aeroplane();
        // badAirplane.Drive(); // This would throw an exception
        badAirplane.Fly();

        // In a real application, avoid using the bad example to prevent ISP violation issues
    }
}