using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Missing_Numbers_in_a_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> values = new SortedSet<int>() { 1, 2, 4, 5, 7 };
            for(int i = 1; i < 7; i++)
            {
                if (!values.Contains(i))
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
