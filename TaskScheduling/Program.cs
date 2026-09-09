using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskScheduling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> tasks = new Queue<string>();
            tasks.Enqueue("task4");
            tasks.Enqueue("task3");
            tasks.Enqueue("task2");
            tasks.Enqueue("task1");
            while (tasks.Count > 0)
            {
                string currentTask = tasks.Dequeue();
                Console.WriteLine($"Processing: {currentTask}");
            }
        }
    }
}
