using Interface_Segregation_Principle.Bad_Examples.Interfaces.Example2_Role_Based_Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.Bad_Examples.Implementations.Example2_Role_Based_Tasks
{
    internal class Developer : IEmployeeTasks
    {
        // Cannot create task.
        public void CreateTask()
        {
            Console.WriteLine("Task created.");
        }

        // Cannot create task.
        public void CreateSubTask()
        {
            Console.WriteLine("Sub Task created.");
        }

        // Cannot assign task.
        public void AssignTask()
        {
            Console.WriteLine("Task assigned.");
        }

        public void WorkOnTask()
        {
            Console.WriteLine("Started working on the task.");
        }
    }
}
