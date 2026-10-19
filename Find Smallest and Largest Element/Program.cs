using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Smallest_and_Largest_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> set = new SortedSet<int> { 4, 2, 5, 1, 3 };
            Console.WriteLine($"Smallest:{set.Min},Largest:{set.Max}");
        }
    }
}
