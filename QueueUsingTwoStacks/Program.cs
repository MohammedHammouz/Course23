using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueUsingTwoStacks
{
    internal class Program
    {
        static Stack<int> stack1 = new Stack<int>();
        static Stack<int> stack2 = new Stack<int>();
        static void Enqueue(Queue<int>queue)
        {
            stack1.Push(queue.Dequeue());
        }
        static int Dequeue(Queue<int> queue)
        {
            if (stack2.Count == 0)
            {
                while (stack1.Count > 0)
                {
                    stack2.Push(stack1.Pop());
                }
            }
            return stack2.Pop();
        }
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            Enqueue(queue);
            Enqueue(queue);
            
            Console.Write(Dequeue(queue));
            Console.Write(Dequeue(queue));
        }
    }
}
