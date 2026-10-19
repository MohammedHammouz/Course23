using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Elements_Not_in_the_Second_Array
{
    internal class Program
    {
        static int[] ElementsNotInSecondArray(int[] nums1, int[] nums2)
        {
            HashSet<int> set = new HashSet<int>(nums2);
            List<int> result = new List<int>();
            foreach(var num in nums1)
            {
                if (!set.Contains(num))
                {
                    result.Add(num);
                }
            }
            return result.ToArray();
        }
        static HashSet<int> ElementsNotInSecondArray2(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> Num = new Dictionary<int, int>();
            HashSet<int> set = new HashSet<int>();
            foreach (var num in nums1)
            {
                if (!Num.ContainsKey(num))
                    Num[num] = 1;
                else
                    Num[num]++;
            }
            foreach (var num in nums2)
            {
                if (Num.ContainsKey(num))
                {
                    Num[num]--;
                }

            }
            foreach (var num in Num)
            {
                if (num.Value != 0)
                {
                    set.Add(num.Key);
                }
            }
            return set;
        }
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3, 4 };
            int[] nums2 = {  5, 6 };
            Stopwatch sw = new Stopwatch();

            sw.Start();
            ElementsNotInSecondArray2(nums1, nums2);
            sw.Stop();
            Console.WriteLine($"My Solution: {sw.Elapsed.TotalMilliseconds} ms");

            sw.Start();
            ElementsNotInSecondArray(nums1, nums2);
            sw.Stop();
            Console.WriteLine($"Abu Hadhoud's Solution: {sw.Elapsed.TotalMilliseconds} ms");
        }
    }
}
