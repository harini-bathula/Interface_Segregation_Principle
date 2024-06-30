using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.Good_Examples.Implementations.Example3_Worker_Type
{

    internal class Robot: IWorkable
    {
        public void Work() => Console.WriteLine($"{nameof(Human)} {nameof(Work)}");
    }
}