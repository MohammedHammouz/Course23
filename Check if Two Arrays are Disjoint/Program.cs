using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_if_Two_Arrays_are_Disjoint
{
    internal class Program
    {
        static bool IsTwoArraysIsDisjoint(int[] nums1, int[] nums2)
        {
            HashSet<int> set = new HashSet<int>(nums1);
            foreach(var num in nums2)
            {
                if (set.Contains(num))
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3 };
            int[] nums2 = { 4, 5, 6 };
            Console.WriteLine(IsTwoArraysIsDisjoint(nums1, nums2));
        }
    }
}
