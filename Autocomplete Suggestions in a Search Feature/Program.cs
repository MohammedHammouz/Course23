using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autocomplete_Suggestions_in_a_Search_Feature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> features = new SortedSet<string>()
            {
                "Apple",
                "Application",
                "Banana",
                "Application Development",
                "Apricot"

            };
            Console.WriteLine("Enter Perfix:");
            string perfix = Console.ReadLine();
            foreach(var feature in features)
            {
                if (feature.StartsWith(perfix))
                    Console.Write($"{feature}  ");
            }
            Console.ReadKey();
        }
    }
}
