using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Duplicate_Elements
{
    internal class Program
    {
        static List<int> DuplicationNumbers(int[] nums)
        {
            List<int> Duplications = new List<int>();
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            foreach(int num in nums)
            {
                if (!numbers.ContainsKey(num))
                    numbers[num] = 0;
                numbers[num]++;
                if (numbers[num] == 2)
                        Duplications.Add(num);
                
            }
            return Duplications;
        }
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 2, 5, 6, 1, 6 };
            Console.WriteLine(string.Join(",", DuplicationNumbers(nums)));
        }
    }
}
