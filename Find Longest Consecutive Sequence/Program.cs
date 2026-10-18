using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Longest_Consecutive_Sequence
{
    internal class Program
    {
        static int LongestConsecutive(int[] nums)
        {
            HashSet<int> set = new HashSet<int>(nums);
            int longestStreak = 0;
            foreach(int num in set)
            {
                if (!set.Contains(num - 1))
                {
                    int currentNum = num;
                    int currentStreak = 1;
                    while (set.Contains(currentNum + 1))
                    {
                        currentNum++;
                        currentStreak++;
                    }
                    longestStreak = Math.Max(longestStreak, currentStreak);
                }
            }
            return longestStreak;
        }
        static void Main(string[] args)
        {
            int[] nums = { 100, 4, 200, 1, 3, 2 };
            Console.WriteLine(LongestConsecutive(nums));
        }
    }
}
