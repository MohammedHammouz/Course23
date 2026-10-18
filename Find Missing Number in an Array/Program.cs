using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Missing_Number_in_an_Array
{
    internal class Program
    {
        static int FindMissingNumbers(int[] numbers)
        {
            Dictionary<int, int> Num = new Dictionary<int, int>();
            for(int i= 0; i < numbers.Length; i++)
            {
                Num[i] = 1;
            }
            foreach(var num in numbers)
            {
                if (Num.ContainsKey(num))
                {
                    Num[num] = 0;
                }
            }
            foreach(var num in Num)
            {
                if (num.Value == 1)
                {
                    return num.Key;
                }
            }
            return -1;
        }
        static int FindMissingNumber(int[] nums)
        {
            HashSet<int> set = new HashSet<int>(nums);
            int n = nums.Length;


            for (int i = 0; i <= n; i++)
            {
                if (!set.Contains(i))
                    return i;
            }

            return -1;
        }
        static void Main(string[] args)
        {
            int[] numbers = { 3, 0, 1 };
            Stopwatch sw = new Stopwatch();

            sw.Start();
            FindMissingNumbers(numbers);
            Console.WriteLine($"MySolution: {sw.Elapsed.TotalMilliseconds} ms");
            sw.Stop();
            sw.Start();
            FindMissingNumber(numbers);
            Console.WriteLine($"Abu HadhoudSolution: {sw.Elapsed.TotalMilliseconds} ms");
            sw.Stop();
        }
    }
}
