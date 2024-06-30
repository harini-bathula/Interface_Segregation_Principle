using Interface_Segregation_Principle.Good_Examples.Interfaces.Example5_Printing_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.Good_Examples.Implementations.Example5_Printing_System
{
    class CanonPrinter : IPrintScanContent
    {
        public bool PhotoCopyContent(string content)
        {
            Console.WriteLine("PhotoCopy Done");
            return true;

        }
        public bool PrintContent(string content)
        {
            Console.WriteLine("Print Done");
            return true;

        }
        public bool ScanContent(string content)
        {
            Console.WriteLine("Scan Done");
            return true;
        }
    }
}
