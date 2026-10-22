using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Seating_Arrangement_in_a_Classroom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] classroomSeats = new int[3][] { new int[] { 1, 2, 3 }, new int[] { 4, 5 }, new int[] { 6, 7, 8, 9 } };
            for(int i = 0; i < classroomSeats.Length; i++)
            {
                Console.Write($"Row {i + 1}: ");
                foreach (int seat in classroomSeats[i])
                {
                    Console.Write(seat + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
