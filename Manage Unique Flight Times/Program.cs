using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Unique_Flight_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<DateTime> flightTimes = new SortedSet<DateTime>()
                {
                    new DateTime(2024, 11, 19, 8, 0, 0),
                    new DateTime(2024, 11, 19, 12, 45, 0),
                    new DateTime(2024, 11, 19, 8, 0, 0) // Duplicate, won't be added
                };
            Console.WriteLine("Flight times (sorted):");
            foreach (var time in flightTimes)
            {
                Console.WriteLine(time.ToShortTimeString());
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
