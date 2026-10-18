using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Find_Majority_Element
{
    internal class Program
    {
        static int FindMajorElement(int[] nums)
        {
            int MajorElement = nums.Length / 2;
            Dictionary<int, int> Numbers = new Dictionary<int, int>();
            foreach(var num in nums)
            {
                if (!Numbers.ContainsKey(num))
                {
                    Numbers[num] = 0;
                }
                Numbers[num]++;
                if (Numbers[num] > MajorElement)
                {
                    return num;
                }
            }
            return -1;
        }
        
        static void Main(string[] args)
        {
            int[] nums = { 1,2,3,4 };
            Console.WriteLine(FindMajorElement(nums));
        }
    }
}
