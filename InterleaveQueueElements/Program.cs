using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterleaveQueueElements
{
    internal class Program
    {
        static Queue<int> InterLeaveQueue(Queue<int> queue)
        {
            //Stack<int> FirstHalf = new Stack<int>();
            //Stack<int> SecondHalf = new Stack<int>();
            //int Half = queue.Count / 2;
            //while (queue.Count > Half)
            //{
            //    FirstHalf.Push(queue.Dequeue());
            //}
            //while (queue.Count > 0)
            //{
            //    SecondHalf.Push(queue.Dequeue());
            //}
            //Stack<int> stack = new Stack<int>();
            //while (FirstHalf.Count > 0 && SecondHalf.Count > 0)
            //{
            //    stack.Push(SecondHalf.Pop());
            //    stack.Push(FirstHalf.Pop());

            //}
            //return new Queue<int>(stack);
            Stack<int> stack = new Stack<int>();

            int HalfQueue = queue.Count/2;
            for (int i = 0;i<HalfQueue;i++)
            {
                stack.Push(queue.Dequeue());
            }
            //stack{6,5,4} queue{1,2,3}
            for (int i = 0; i < HalfQueue; i++)
            {
                queue.Enqueue(stack.Pop());
            }
           
            //stack{}   queue{6,5,4,1,2,3}
            for (int i = 0; i < HalfQueue; i++)
            {
                queue.Enqueue(queue.Dequeue());
            }

            //stack{}    {1,2,3,6,5,4}
           
            for (int i = 0; i < HalfQueue; i++)
            {
                stack.Push(queue.Dequeue());
               
            }
            //stack{4,5,6}    queue{1,2,3}
            for(int i = 0; i < HalfQueue; i++)
            {
                queue.Enqueue(stack.Pop());
                queue.Enqueue(queue.Dequeue());
            }
            return queue;
           

        }
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4, 5 ,6});
            Console.WriteLine(string.Join(",", InterLeaveQueue(queue)));
            //stack ={1,2,3}                   queue = {4, 5 ,6}
        }
    }
}
