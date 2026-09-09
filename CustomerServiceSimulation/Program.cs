using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerServiceSimulation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Queue<string> customers = new Queue<string>();
            customers.Enqueue("customer4");
            customers.Enqueue("customer3");
            customers.Enqueue("customer2");
            customers.Enqueue("customer1");
            Console.WriteLine("Serving customers:\n");
            while (customers.Count > 0)
            {
                string currentCustomer = customers.Dequeue();
                Console.WriteLine($"Serving: {currentCustomer}");
            }
        }
    }
}
