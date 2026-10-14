using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rearrange_Even_and_Odd_Elements
{

    internal class Program
    {
        static Queue<int> RearrangeEvenOdd(Queue<int> queue)
        {
            Queue<int> evenQueue = new Queue<int>();
            Queue<int> oddQueue = new Queue<int>();


            while (queue.Count > 0)
            {
                int num = queue.Dequeue();
                if (num % 2 == 0)
                {
                    evenQueue.Enqueue(num);
                }
                else
                {
                    oddQueue.Enqueue(num);
                }
            }


            while (evenQueue.Count > 0)
            {
                queue.Enqueue(evenQueue.Dequeue());
            }


            while (oddQueue.Count > 0)
            {
                queue.Enqueue(oddQueue.Dequeue());
            }

            return queue;
        }

        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>(new int[] { 1, 2, 3, 4, 5, 6 });
            queue = RearrangeEvenOdd(queue);
            Console.WriteLine(string.Join(", ", queue));
        }
    }
}
