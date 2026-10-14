using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RearrangeQueueAlternately
{
    internal class Program
    {
        static Queue<int> RearrangeQueue(Queue<int>queue) 
        {
            Queue<int> q = new Queue<int>();
            Stack<int> s = new Stack<int>();
            int HalfQueue = queue.Count / 2;
            for(int i = 0; i < HalfQueue; i++)
            {
                q.Enqueue(queue.Dequeue());
            }
            for(int i = 0; i < HalfQueue; i++)
            {
                s.Push(queue.Dequeue());
            }
            for(int i = 0; i < HalfQueue; i++)
            {
                queue.Enqueue(q.Dequeue());
                queue.Enqueue(s.Pop());
            }
            return queue;    
        }
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(",", RearrangeQueue(new Queue<int>(new[] { 1, 2, 3, 4, 5, 6 }))));
        }
    }
}
