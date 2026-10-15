using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clone_a_Queue_Without_Using_Extra_Space
{
    internal class Program
    {
        static Queue<int> CloneAQueue(Queue<int> queue,int count)
        {
            if (count > 0)
            {
                CloneAQueue(queue, count - 1);
                queue.Enqueue(queue.Dequeue());
            }
            return queue;
        }
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>(new int[] { 1, 2, 3, 4 });
            Queue<int>  clonedQueue = CloneAQueue(queue, queue.Count);
            Console.WriteLine(string.Join(",", clonedQueue));
        }
    }
}
