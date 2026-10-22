using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Optimizing_Space_in_Large_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BitArray seats = new BitArray(1000, false);
            seats[100] = true;
            seats[999] = true;
            Console.WriteLine($"Seat 101 booked: {seats[100]}");
            Console.WriteLine($"Seat 1000 booked: {seats[999]}");
            Console.ReadKey();
        }
    }
}
