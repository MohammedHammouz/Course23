using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateAQueue
{
    internal class Program
    {
        static Queue<int>RotatQueue(Queue<int> queue,int k)
        {
            k = k % queue.Count;
           
            while (k >=1)
            {
                Console.WriteLine(string.Join(",", queue));
                queue.Enqueue(queue.Dequeue());
                k--;
            }
            //{1,2,3,4,5}
            //1   {4,5,1,2,3}
            return queue;
        }
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>(new []{ 1, 2, 3, 4, 5});
            Console.WriteLine(string.Join(",",(RotatQueue(queue, 17))));
        }
    }
}
