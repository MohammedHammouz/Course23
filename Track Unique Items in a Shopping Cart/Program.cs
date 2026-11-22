using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Track_Unique_Items_in_a_Shopping_Cart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> Carts = new SortedSet<string>()
            {
                "Apple",
                "Milon",
                "Banana"
            };
            Console.WriteLine(string.Join(",", Carts));
            Console.ReadKey();
        }
    }
}
