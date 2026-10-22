using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Copy_Hashtable_to_Another_Hashtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht1 = new Hashtable();
            ht1.Add("One", 1);
            ht1.Add("Two", 2);
            ht1.Add("Three", 3);
            Hashtable ht2 = new Hashtable(ht1);
            Console.WriteLine("Contents of copied Hashtable:");
            foreach (DictionaryEntry entry in ht2)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
