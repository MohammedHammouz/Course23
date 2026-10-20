using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_All_Elements_Within_a_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> set = new SortedSet<int> { 1, 2, 3, 4, 5 };
            set.GetViewBetween(2, 4).Clear();
            Console.WriteLine(string.Join(",", set));
        }
    }
}
