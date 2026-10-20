using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Count_of_Elements_Less_Than_or_Equal_to_a_Value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> set = new SortedSet<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var range = set.GetViewBetween(int.MinValue, 3).Count;
            Console.WriteLine(range);
        }
    }
}
