using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_All_Elements_Not_in_a_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> set = new SortedSet<int> { 1, 2, 3, 4, 5 };
            var range = set.GetViewBetween(2, 4);
            SortedSet<int> result = new SortedSet<int>(set);
            result.ExceptWith(range);
            Console.WriteLine(string.Join(",", result));
        }
    }
}
