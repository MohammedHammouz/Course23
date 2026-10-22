using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_and_Remove_Duplicates_from_a_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 5, 2, 8, 2, 5, 1, 8, 3 };
            SortedSet<int> result = new SortedSet<int>(numbers);
            Console.Write(string.Join(",", result));
        }
    }
}
