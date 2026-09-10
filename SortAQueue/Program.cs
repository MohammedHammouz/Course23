using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAQueue
{
    internal class Program
    {
        static Queue<int>SortedAQueue(Queue<int> queue)
        {
            List<int> array = new List<int>(queue);
            array.Sort();
            return new Queue<int>(array);
        }
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>(new int[] { 2, 3, 1, 5, 4 });
            Console.WriteLine(string.Join(",", SortedAQueue(queue)));
            Console.ReadKey();
        }
    }
}
