using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Elements_in_a_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Low = 2;
            int High = 4;
            SortedSet<int> list = new SortedSet<int> { 1, 2, 3, 4, 5 };
            var range = list.GetViewBetween(Low, High);
            Console.WriteLine(string.Join(", ", range)); // Output: 2, 3, 4
            Console.ReadKey();

        }
    }
}
