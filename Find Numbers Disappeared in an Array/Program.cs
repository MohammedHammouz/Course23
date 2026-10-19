using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Numbers_Disappeared_in_an_Array
{
    internal class Program
    {
        static List<int> FindDisappearedNumbers(int[] nums)
        {
            HashSet<int> set = new HashSet<int>(nums);
            List<int> result = new List<int>();
            for(int i = 1; i <= nums.Length; i++)
            {
                if (!set.Contains(i))
                    result.Add(i);
            }
            return result;
        }
        static void Main(string[] args)
        {
            int[] nums = { 4, 3, 2, 7, 8, 2, 3, 1 };
            Console.WriteLine(string.Join(",", FindDisappearedNumbers(nums)));
        }
    }
}
