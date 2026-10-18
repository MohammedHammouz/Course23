using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_All_Unique_Elements
{
    internal class Program
    {
        static List<int> FindUniqueElements(int[] nums)
        {
            List<int> Uniques=new List<int>();
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            foreach(int num in nums)
            {
                if (!numbers.ContainsKey(num))
                    numbers[num] = 0;
                numbers[num]++;
            }
            foreach(var num in numbers)
            {
                if (num.Value == 1)
                    Uniques.Add(num.Key);
            }
            return Uniques;
        }
        static void Main(string[] args)
        {

            int[] nums = { 1, 2, 2, 3, 4, 5, 3 };
            Console.WriteLine(string.Join(", ", FindUniqueElements(nums)));
        }
    }
}
