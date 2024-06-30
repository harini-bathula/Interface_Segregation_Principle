using Interface_Segregation_Principle.Bad_Examples.Interfaces.Example3_Worker_Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.Bad_Examples.Implementations.Example3_Worker_Type
{
    internal class Robot : IWorker
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Work() => Console.WriteLine($"{nameof(Human)} {nameof(Work)}");
    }
}
