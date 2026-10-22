using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Sales_Data_by_Quarter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] salesData = new int[][] { new int[] { 10000, 12000, 11000 }, new int[] { 15000, 16000 }, new int[] { 9000, 9500, 9800, 10200 } };
            for (int i = 0; i < salesData.Length; i++){
                Console.Write($"Region{i+1}:");
                Console.WriteLine(string.Join(",", salesData[i]));
            }
        }
    }
}
