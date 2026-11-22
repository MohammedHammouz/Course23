using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule_Tasks_Based_on_Priority
{
    class Task : IComparable<Task>
    {
        public int Priority { get; set; }
        public string Description { get; set; }
        public int CompareTo(Task other)
        {
            int result = this.Priority.CompareTo(other.Priority);
            if (result == 0)
            {
                // If priorities are equal, compare descriptions to avoid duplicates
                result = this.Priority.CompareTo(other.Priority);
            }
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<Task> tasks = new SortedSet<Task>
            {
                new Task { Priority = 2, Description = "Write report" },
                new Task { Priority = 1, Description = "Fix critical bug" },
                new Task { Priority = 3, Description = "Team meeting" }
            };
            // Add a new task with same priority
            tasks.Add(new Task { Priority = 2, Description = "Review PRs" });


            Console.WriteLine("Tasks in priority order:\n");
            foreach (var task in tasks)
            {
                Console.WriteLine($"Priority: {task.Priority}, Task: {task.Description}");
            }


            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
