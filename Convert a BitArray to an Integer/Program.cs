using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_a_BitArray_to_an_Integer
{
    internal class Program
    {
        static int BitArrayToInt(BitArray bits)
        {
            int result = 0;
            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i])
                {
                    result += (1 << i); // Add the value of the current bit
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            BitArray bits = new BitArray(new bool[] { true, false, true });
            int number = BitArrayToInt(bits);
            Console.WriteLine("Integer value of BitArray: " + number);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
