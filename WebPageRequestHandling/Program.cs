using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPageRequestHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Queue<string> requests = new Queue<string>();
            requests.Enqueue("Request3");
            requests.Enqueue("Request2");
            requests.Enqueue("Request1");
            while (requests.Count > 0)
            {
                string currentRequest = requests.Dequeue();
                Console.WriteLine($"Processed: {currentRequest}");
            }
        }
    }
}
