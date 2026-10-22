using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatically_Sort_Event_Timelines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> events = new SortedList<int, string>()
            {
                { 5, "Event A" },
                { 2, "Event B" },
                { 4, "Event C" },
                { 1, "Event D" }
            };

            foreach (var e in events)
            {
                 Console.WriteLine($"{e.Key} - {e.Value}");
            }
         }
    }
}
