using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Elements_Greater_Than_a_Value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> sortedSet = new SortedSet<int> { 1, 2, 3, 4, 5 };
            var range = sortedSet.GetViewBetween(int.MinValue, 2);
            sortedSet = new SortedSet<int>(range);
            Console.WriteLine(string.Join(", ", sortedSet)); // Output: 1, 2, 3
            Console.WriteLine(range.Count);
            Console.ReadKey();
        }
    }
}
