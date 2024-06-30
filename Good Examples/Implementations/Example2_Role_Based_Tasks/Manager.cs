using Interface_Segregation_Principle.Good_Examples.Interfaces.Example2_Role_Based_Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.Good_Examples.Implementations.Example2_Role_Based_Tasks
{
    internal class Manager : ILead
    {
        public void CreateTask()
        {
            Console.WriteLine("Task created.");
        }

        public void CreateSubTask()
        {
            Console.WriteLine("Sub Task created.");
        }

        public void AssignTask()
        {
            Console.WriteLine("Task assigned.");
        }
    }

}
