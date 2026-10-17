using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_and_Retrieve_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> students = new Dictionary<string, double>{
            { "Alice", 85.5 },
            { "Bob", 90.0 },
            { "Charlie", 78.5 }
        };

            Console.WriteLine($"Student:Bob,Grade:{students["Bob"]}");
            
        }
    }
}
