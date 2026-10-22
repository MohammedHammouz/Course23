using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perform_Bitwise_AND_Between_Two_BitArrays
{
    internal class Program
    {
        static BitArray PerformBitwise(BitArray array1,BitArray array2)
        {
            if(array1.Length!=array2.Length)
                throw new ArgumentException("BitArrays must have the same length!");
            return array1.And(array2);

        }
        static void Main(string[] args)
        {
            BitArray array1 = new BitArray(new bool[] { true, false, false, false, true, true, false, false });
            BitArray array2 = new BitArray(new bool[] { true, false, true, true, false, true, false, false });
           
            BitArray array3 = new BitArray(PerformBitwise(array1, array2));
            foreach (bool bit in array3)
                    Console.Write($"{bit}  ");
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
