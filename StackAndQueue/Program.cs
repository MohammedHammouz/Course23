using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace StackAndQueue
{
    public class StackImplementation<T>
    {
        Stack<T> history = new Stack<T>();
        public void Add(T element)
        {
            history.Push(element);
        }
        public T Remove()
        {
            return history.Pop();
        }
        public T TopElement()
        {
            return history.Peek();
        }
        
    }
    internal class Program
    {
        static string DecimalToBinary(int number)
        {
            Stack<int> stack = new Stack<int>();

            while (number > 0)
            {
                stack.Push(number % 2);
                number /= 2;
            }

            return string.Join("", stack);
        }
       
        static void Main(string[] args)
        {
            StackImplementation<string> history = new StackImplementation<string>();
            history.Add("Page1");
            history.Add("Page2");
            history.Add("Page3");
            history.Add("Page4");
            Console.WriteLine(history.TopElement());
            Console.WriteLine("Back from: " + history.Remove()); // Output: Back from: Page3
            Console.WriteLine("Current Page: " + history.TopElement()); // Output: Current Page: Page2
            Console.WriteLine(DecimalToBinary(7));
            Stack<int> calculatorStack = new Stack<int>();
            calculatorStack.Push(10);
            calculatorStack.Push(20);
            calculatorStack.Push(30);


            Console.WriteLine("Undo: " + calculatorStack.Pop()); // Output: Undo: 30
            Console.WriteLine("Current Result: " + calculatorStack.Peek()); // Output: Current Result: 20
            Queue<string> printerQueue = new Queue<string>();
            printerQueue.Enqueue("document1");
            printerQueue.Enqueue("document2");
            printerQueue.Enqueue("document3");
            Console.WriteLine("Processing: " + printerQueue.Dequeue()); // Output: Processing: Document1
            Console.WriteLine("Next Job: " + printerQueue.Peek());
            // Initialize a queue to represent vehicles at the traffic signal
            Queue<string> trafficQueue = new Queue<string>();


            // Add vehicles to the queue
            trafficQueue.Enqueue("Car 1");
            trafficQueue.Enqueue("Truck 1");
            trafficQueue.Enqueue("Bike 1");
            trafficQueue.Enqueue("Bus 1");
            while (trafficQueue.Count > 0)
            {
                string vehicle = trafficQueue.Dequeue();
                Console.WriteLine($"{vehicle} has passed the signal.\n");

            }
            Queue<int> ticketQueue = new Queue<int>();
            
            for(int i = 101; i <= 105; i++)
            {
                ticketQueue.Enqueue(i);
                Console.WriteLine($"Ticket {i} issued.");
            }
            while (ticketQueue.Count > 0)
            {
                int currentTicket = ticketQueue.Dequeue();
                Console.WriteLine($"Processing Ticket: {currentTicket}");
                if(ticketQueue.Count > 0)
                {
                    Console.WriteLine("Remaining Tickets: " + string.Join(", ", ticketQueue));
                }
                else
                {
                    Console.WriteLine("No more tickets in the queue.");
                }


            }
            Stack<string> stackBacktracking = new Stack<string>();
            stackBacktracking.Push("Start");
            stackBacktracking.Push("Go to Gaz Station");
            stackBacktracking.Push("Go to Super Market");
            stackBacktracking.Push("Go To Work");
            stackBacktracking.Push("Go to Cafe");
            stackBacktracking.Push("Go Home");
            Console.WriteLine("Backtracking...");
            Stack<string> Backtracking = new Stack<string>();
            while (stackBacktracking.Count > 0)
            {
                if (stackBacktracking.Count == 6)
                {
                    Backtracking.Push(stackBacktracking.Peek());
                }
                else
                {
                    Backtracking.Push(stackBacktracking.Peek() + " -> ");
                }
                Console.WriteLine("Back to:" + stackBacktracking.Peek());
                
                stackBacktracking.Pop();
            }

            Console.WriteLine(string.Join(" ",Backtracking));
            Console.ReadKey();
        }
    }
}
