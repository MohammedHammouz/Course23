using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Union_of_Two_SortedSets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> set1 = new SortedSet<int> { 1, 2, 3 };
            SortedSet<int> set2 = new SortedSet<int> { 3, 4, 5 };
            set1.UnionWith(set2);
            Console.WriteLine(string.Join(",", set1));
        }
    }
}
