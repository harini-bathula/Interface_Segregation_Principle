using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.Bad_Examples.Interfaces.Example2_Role_Based_Tasks
{
    internal interface IEmployeeTasks
    {
        void CreateTask();
        void CreateSubTask();
        void AssignTask();
        void WorkOnTask();
    }

}
