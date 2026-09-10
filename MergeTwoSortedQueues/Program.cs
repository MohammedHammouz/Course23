using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeTwoSortedQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue1 = new Queue<int>(new[] { 1, 2, 3});
            Queue<int> queue2 = new Queue<int>(new[] { 4, 5, 6 });
            Queue<int> merged = new Queue<int>();
            while (queue2.Count > 0 && queue1.Count>0)
            {
                if (queue1.Peek() <= queue2.Peek())
                {
                    merged.Enqueue(queue1.Dequeue());
                }
                else
                {
                    merged.Enqueue(queue2.Dequeue());
                }
               
            }
            while (queue1.Count > 0)
            {
                merged.Enqueue(queue1.Dequeue());
            }
            while (queue2.Count > 0)
            {
                merged.Enqueue(queue2.Dequeue());
            }
            Console.WriteLine(string.Join(",",merged));
        }
    }
}
