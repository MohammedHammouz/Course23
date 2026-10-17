using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_for_Duplicate_Entries_in_Real_Time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> dataEntries = new HashSet<string>();
            string[] entries = { "A", "B", "C", "A" };
            foreach(var entry in entries)
            {
                if (!dataEntries.Add(entry))
                {
                    Console.WriteLine($"Duplicate detected: {entry}");
                }
            }
        }
    }
}
