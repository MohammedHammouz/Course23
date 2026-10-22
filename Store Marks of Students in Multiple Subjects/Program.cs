using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Marks_of_Students_in_Multiple_Subjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] students = new int[][] { new int[] { 90, 85, 88 }, new int[] { 76, 80 }, new int[] { 92, 93, 89, 85 } };
            for(int i = 0; i < students.Length; i++)
            {
                Console.Write($"Student{i+1}:");
                Console.WriteLine(string.Join(",", students[i]));
            }
        }
    }
}
