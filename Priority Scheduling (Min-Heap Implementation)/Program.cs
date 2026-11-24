using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priority_Scheduling__Min_Heap_Implementation_
{
    class Task
    {
        public string Name { get; set; }
        public int Priority { get; set; }
        public Task(string name,int priority)
        {
            Name = name;
            Priority = priority;
        }
    }
    class MinHeap
    {
        private List<Task> heap = new List<Task>();
        public void Insert(Task task)
        {
            heap.Add(task);
            HeapyfyUp(heap.Count - 1);
        }
        private void HeapyfyUp(int index)
        {
            while(index>0 )
            {
                int parentIndex = (index - 1) / 2;
                if (heap[index].Priority >= heap[parentIndex].Priority) break;
                Swap(index, (index - 1) / 2);
                index = parentIndex;
            }
        }
        private void HeapifyDown(int index)
        {
            int smallest = index;
            int left = 2 * index + 1;
            int right = 2 * index + 2;

            if (left < heap.Count && heap[smallest].Priority < heap[left].Priority)
                smallest = left;
            if (right < heap.Count && heap[smallest].Priority > heap[right].Priority)
                smallest = right;
            if (smallest != index)
            {
                Swap(index, smallest);
                HeapifyDown(smallest);
            }
        }
        public Task ExtractMin()
        {
            if (heap.Count == 0) return null;


            var minTask = heap[0];
            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);
            HeapifyDown(0);


            return minTask;
        }

        private void Swap(int i,int j)
        {
            var temp = heap[i];
            heap[i] = heap[j];
            heap[j] = temp;
        }
        public bool IsEmpty()
        {
            return heap.Count == 0;
        }
        public void Print()
        {
            foreach(var task in heap)
            {
                Console.WriteLine($"{task.Name},{task.Priority}");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var scheduler = new MinHeap();

            // Add tasks with priorities
            scheduler.Insert(new Task("Task A", 3));
            scheduler.Insert(new Task("Task B", 1));
            scheduler.Insert(new Task("Task C", 2));
            Console.WriteLine("Tasks entered in this order: Task A, Task B, Task C.\n");
            // Process tasks in priority order
            Console.WriteLine("Executing tasks in priority order:");
            while (!scheduler.IsEmpty())
            {
                //Console.WriteLine(scheduler.ExtractMin());
                Task task = scheduler.ExtractMin();
                Console.WriteLine($"{task.Name}, {task.Priority}");
            }
            scheduler.Print();
        }
    }
}
