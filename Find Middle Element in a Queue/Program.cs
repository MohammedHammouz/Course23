using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Middle_Element_in_a_Queue
{
    
    internal class Program
    {
        static int FindMiddleElement(Queue<int> queue)
        {
            List<int> list = new List<int>(queue);
            return list[list.Count / 2];
        }
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>(new int[] { 1, 2, 3, 4, 5 });
            Console.WriteLine(FindMiddleElement(queue));
        }
    }
}
